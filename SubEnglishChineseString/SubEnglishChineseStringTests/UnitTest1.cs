using System;
using Xunit;
using SubEnglishChineseString;

namespace SubEnglishChineseStringTests
{
    public class UnitTest1
    {
        [Fact]
        public void SubBig5StringTest()
        {
            String str = "TESTWORD���դ�rTEST";
            Assert.Equal("ESTWORD���դ�r", Program.SubBig5String(str, 1, 15));
        }
    }
}
