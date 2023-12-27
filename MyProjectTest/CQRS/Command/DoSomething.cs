using KhatiMediaTr;
using MyProjectTest.Services;

namespace MyProjectTest.CQRS.Command
{
    public class DoSomething : IEventHandler
    {
        private readonly IMyService _myService;
        public DoSomething(IMyService myService)
        {
            _myService = myService;
        }
        public bool Handler()
        {
            _myService.Wait();
            return true;    
        }
    }
}
