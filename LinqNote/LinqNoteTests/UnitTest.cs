using LinqNote.Command;
using Moq;
using Xunit;

namespace LinqNoteTests
{
    public class UnitTest
    {
        [Fact]
        public void Run()
        {
            LINQElementOperatorCommandTest();
        }

        /// <summary>
        /// LINQElementOperatorCommandTest
        /// </summary>
        [Fact]
        public void LINQElementOperatorCommandTest()
        {
            var mock = new Mock<LINQElementOperatorCommand>();
            var command = mock.Object;
            var res = command.Run();
            Assert.True(res);
        }
    }
}
