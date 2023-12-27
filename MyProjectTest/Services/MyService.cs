namespace MyProjectTest.Services
{
    public class MyService : IMyService
    {
        public IOtherDependency _otherDependency;
        public MyService(IOtherDependency otherDependency)
        {
            _otherDependency = otherDependency;
        }
        public string Print()
        {
            return "Hello World";
        }

        public (string message, string description) PrintTupple()
        {
            return ("Hello World","I am Tupple");
        }

        public List<MyModel> GetModel()
        {
            MyModel model = new MyModel() { MyObject = "Hello" };
            List<MyModel> list = new List<MyModel>();
            list.Add(model);
            return list;
        }

        //You can Add parameters as per as your requirements
        public AddParms Request(string value, string value1 , List<MyModel> myModel, MyModel model)
        {
            AddParms parms = new AddParms()
            {
                value = value,
                value1 = value1,
                myModel = myModel,
                model = model
            };
            return parms;
        }
        public void Wait()
        {
           _otherDependency.Wait();
        }
    }
}
public class MyModel
{
    public string MyObject { set; get; }
}

public class AddParms
{
    public string value { set; get; }   
    public string value1 { set; get; }   
    public List<MyModel> myModel { set; get; }
    public MyModel model { set; get; }  

}
