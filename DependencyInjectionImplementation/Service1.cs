namespace DependencyInjectionImplementation
{
    public class Service1 : IService
    {
        public void LogData(string data)
        {
            Console.WriteLine("logging data from service1: " + data);
        }
    }
}
