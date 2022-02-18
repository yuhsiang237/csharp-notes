using LinqNote.Command;

namespace LinqNote
{
    class Startup
    {
        private readonly ILINQElementOperatorCommand _LINQElementOperatorCommand;

        public Startup(ILINQElementOperatorCommand LINQElementOperatorCommand)
        {
            _LINQElementOperatorCommand = LINQElementOperatorCommand;
        }

        public void Run()
        {
            _LINQElementOperatorCommand.Run();
        }
    }
}
