using KhatiMediaTr;
using MyProjectTest.Services;

namespace MyProjectTest.CQRS.Query
{
    public class PrintTuple : IEventHandler
    {
        private readonly IMyService _myService;
        public PrintTuple(IMyService myService)
        {
            _myService = myService;
        }

        public (string message, string description) Handler()
        {
            return _myService.PrintTupple();
        }
    }
}
