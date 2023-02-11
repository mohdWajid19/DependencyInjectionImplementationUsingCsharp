namespace DependencyInjectionImplementation
{
    public class Service2 : IService
    {
        public void LogData(string data)
        {
            Console.WriteLine("logging data from service2: " + data);
        }
    }
}
