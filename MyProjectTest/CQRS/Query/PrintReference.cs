using KhatiMediaTr;
using MyProjectTest.Services;

namespace MyProjectTest.CQRS.Query
{
    public class PrintReference : IEventHandler
    {
        private readonly IMyService _myService;
        public PrintReference(IMyService myService)
        {
            _myService = myService;
        }
        public List<MyModel> Handler()
        {
            return _myService.GetModel();
        }
    }
}

