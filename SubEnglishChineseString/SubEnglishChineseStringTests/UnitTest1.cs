using System;
using Xunit;
using SubEnglishChineseString;

namespace SubEnglishChineseStringTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSubEnglishChineseString()
        {
            String str = "TESTWORD測試文字TEST";
            Assert.Equal("ESTWORD測試文字", Program.SubEnglishChineseString(str, 1, 15));
        }
    }
}
