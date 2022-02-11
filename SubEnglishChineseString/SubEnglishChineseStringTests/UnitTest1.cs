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
            String str = "TESTWORD���դ�rTEST";
            Assert.Equal("ESTWORD���դ�r", Program.SubEnglishChineseString(str, 1, 15));
        }
    }
}
