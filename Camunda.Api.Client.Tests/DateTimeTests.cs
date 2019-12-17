using System;
using System.Globalization;
using Camunda.Api.Client.Extensions;
using Xunit;

namespace Camunda.Api.Client.Tests
{
    public class DateTimeTests
    {
        [Theory]
        [InlineData("2010-01-01T01:01:01.000", "2010-01-01T01:01:01.000+0100")]
        [InlineData("2010-05-01T01:01:01.000", "2010-05-01T01:01:01.000+0200")]
        public void GetDateTime(string testDateTimeString,string expectedDatetimeString)
        {
            var date = DateTime.Parse(testDateTimeString);
            var actualIso8601DateString = date.ToJavaISO8601();
            var resultDate = DateTime.Parse(actualIso8601DateString);
            Assert.Equal(date, resultDate);
            //compare actualIso8601DateString with regexp instead of this:
            //Assert.Equal(expectedDatetimeString, actualIso8601DateString);
        }
    }
}
