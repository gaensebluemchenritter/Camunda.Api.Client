using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
using Camunda.Api.Client.Infrastructure;

namespace Camunda.Api.Client.Exceptions
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ApiException : Exception
    {
        public string ErrorType { get; }
        public HttpResponseMessage Response { get; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly ConcurrentDictionary<string, Func<string, string, HttpResponseMessage, ApiException>> _knownTypes =
            new ConcurrentDictionary<string, Func<string, string, HttpResponseMessage, ApiException>>();

        public ApiException(string type, string message, HttpResponseMessage response) : base(message)
        {
            ErrorType = type;
            Response = response;
        }

        private static Func<string, string, HttpResponseMessage, ApiException> GetConstructor(string typeName)
        {
            return _knownTypes.GetOrAdd(typeName, typeName_ =>
            {
                Type t = Type.GetType($"{typeof(ApiException).Namespace}.{typeName_}");

                if (t == null || !typeof(ApiException).IsAssignableFrom(t))
                    return null;

                var paramType = Expression.Parameter(typeof(string));
                var paramMessage = Expression.Parameter(typeof(string));
                var paramResponse = Expression.Parameter(typeof(HttpResponseMessage));

                var ctor = t.GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { paramType.Type, paramMessage.Type, paramResponse.Type }, null);

                if (ctor == null)
                    return null;

                var newExpression = Expression.New(ctor, paramType, paramMessage, paramResponse);
                var lambda = Expression.Lambda<Func<string, string, HttpResponseMessage, ApiException>>(newExpression, paramType, paramMessage, paramResponse);

                return lambda.Compile();
            });
        }

        internal static ApiException FromRestError(RestError restError, HttpResponseMessage response)
        {
            var ctor = GetConstructor(restError.Type);
            if (ctor != null)
                return ctor(restError.Type, restError.Message, response);
            else
                return new ApiException(restError.Type, restError.Message, response);
        }
    }
}
