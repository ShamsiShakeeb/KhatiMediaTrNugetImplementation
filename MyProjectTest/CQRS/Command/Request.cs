using KhatiMediaTr;
using MyProjectTest.Services;

namespace MyProjectTest.CQRS.Command
{
    public class Request : IEventHandler
    {
        private readonly IMyService _myService;
        public Request(IMyService myService)
        {
            _myService = myService;
        }
        public AddParms Handler(string value, string value1, List<MyModel> myModel, MyModel model)
        {
            return _myService.Request(value,value1,myModel,model);
        }
    }
}
