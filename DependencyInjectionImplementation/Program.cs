using DependencyInjectionImplementation;

string data = "this is the test Data";
int serviceProviderId = 2;
IService service;
if (serviceProviderId == 1)
{
    service = Injector.GetNewInstanceService1();
}
else
{
    service = Injector.GetNewInstanceService2();
}
service.LogData(data);
