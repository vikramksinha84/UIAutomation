using System;
using NUnit.Framework;

namespace AutomationTest.Utilities
{
    internal class Helper
    {
        /// <summary>
        /// Asset
        /// </summary>
        /// <param name="ActualValue"></param>
        /// <param name="ExpectedValue"></param>
        public static void AssetTrue(string? ActualValue, string? ExpectedValue)
        {
            try
            {
                Assert.True(ActualValue?.Equals(ExpectedValue, StringComparison.OrdinalIgnoreCase), $"{ActualValue} actual value not matched with expected value {ExpectedValue}");
            }
            catch (Exception ex)
            {
                Assert.Fail($"{ActualValue} actual value not matched with expected value {ExpectedValue } Exception message : {ex}");
            }
        }

    }
}
