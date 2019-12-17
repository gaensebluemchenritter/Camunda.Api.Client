using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Camunda.Api.Client.Extensions;
using Xunit;

namespace Camunda.Api.Client.Tests
{
    public class DateTimeTests
    {
        [Theory]
        [InlineData("2010-01-01T01:01:01.000")]
        [InlineData("2010-05-01T01:01:01.000")]
        public void GetDateTime(string testDateTimeString)
        {
            var date = DateTime.Parse(testDateTimeString);
            var actualIso8601DateString = date.ToJavaISO8601();
            var resultDate = DateTime.Parse(actualIso8601DateString);
            Assert.Equal(date, resultDate);
            var regEx = new Regex(@"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}.\d{3}[+-]\d{4}$");
            Assert.Matches(regEx, actualIso8601DateString);
        }
    }
}
