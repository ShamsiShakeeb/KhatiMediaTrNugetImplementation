namespace MyProjectTest.Services
{
    public class OtherDependency : IOtherDependency
    {
        public void Wait()
        {
            Thread.Sleep(1000);
        }
    }
}
