namespace MyProjectTest.Services
{
    public interface IMyService
    {
        string Print();
        (string message, string description) PrintTupple();
        List<MyModel> GetModel();
        AddParms Request(string value, string value1, List<MyModel> myModel, MyModel model);

        void Wait();
    }
}
