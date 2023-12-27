using KhatiMediaTr;
using Microsoft.AspNetCore.Mvc;
using MyProjectTest.CQRS.Command;
using MyProjectTest.CQRS.Query;
namespace MyProjectTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediaTr<PrintQuery, string> _printQuery;
        private readonly IMediaTr<PrintTuple, (string message , string description)> _printTupleMediaTr;
        private readonly IMediaTr<PrintReference, List<MyModel>> _printRefernece;
        private readonly IMediaTr<Request, AddParms> _requestMediaTr;
        private readonly IMediaTr<DoSomething,bool> _requestDoSomething;
        public HomeController(
            IMediaTr<PrintQuery, string> printQuery,
            IMediaTr<PrintTuple, (string message, string description)> printTupleMediaTr,
            IMediaTr<PrintReference, List<MyModel>> printRefernece,
            IMediaTr<Request, AddParms> requestMediaTr,
            IMediaTr<DoSomething, bool> requestDoSomething)
        {
            _printQuery = printQuery;
            _printTupleMediaTr = printTupleMediaTr;
            _printRefernece = printRefernece;
            _requestMediaTr = requestMediaTr;
            _requestDoSomething = requestDoSomething;
        }
        public IActionResult PrintQuery()
        {
            var data = _printQuery.Send();
            return Ok(data);
        }

        public IActionResult PrintTuple()
        {
            var data = _printTupleMediaTr.Send();
            return Ok(new { message = data.message, description = data.description });
        }
        public IActionResult PrintReference()
        {
            var data = _printRefernece.Send();
            return Ok(data);
        }
        public IActionResult FakePostRequest()
        {
            string value = "value";
            string value1 = "value1";
            MyModel model = new MyModel()
            {
                MyObject = "MyObject"
            };
            var data = new List<MyModel>();
            data.Add(model);
            var request = _requestMediaTr.Send(new object[] { value, value1, data, model });
            return Ok(request);
        }

        public IActionResult DoSomething()
        {
            var data = _requestDoSomething.Send();
            return Ok(data);
        }
    }
}