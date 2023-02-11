namespace DependencyInjectionImplementation
{
    public static class Injector
    {
        public static IService GetNewInstanceService1() 
        {
            return new Service1();        
        }
        public static IService GetNewInstanceService2() 
        {
            return new Service2();
        }
    }
}
