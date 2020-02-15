using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Camunda.Api.Client.Resources;
using Newtonsoft.Json;

namespace Camunda.Api.Client.ServiceEndpoints.Authorization
{
    public class AuthorizationInfo
    {
        /// <summary>
        /// the Id of the authorization
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public AuthorizationType? Type { get; set; }

        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("resourceType")]
        public ResourceType? ResourceType { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }
    }
}
