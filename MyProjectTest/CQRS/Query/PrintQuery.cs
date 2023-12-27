using KhatiMediaTr;
using MyProjectTest.Services;

namespace MyProjectTest.CQRS.Query
{
    public class PrintQuery : IEventHandler
    {
        private readonly IMyService _myService;
        public PrintQuery(IMyService myService)
        {
            _myService = myService;
        }

        public string Handler()
        {
            return _myService.Print();
        }

    }
}
