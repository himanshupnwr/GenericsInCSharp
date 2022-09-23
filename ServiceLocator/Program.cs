using ServiceLocator.Services;

public class Program
{
    public void Run(ServiceLocator.ServiceLocator serviceLocator)
    {
        var orderService = serviceLocator.CreateService<IOrderService>();
        var customerService = serviceLocator.CreateService<ICustomerService>();

        var customer = customerService.GetCurrent();
        var order = customerService.CreateOrder(customer);
        orderService.Save(order);
    }

    public ServiceLocator.ServiceLocator Config()
    {
        var serviceLocator = new ServiceLocator.ServiceLocator();
        serviceLocator.AddService<IOrderService, OrderService>();
        serviceLocator.AddService<ICustomerService, CustomerService>();
        return serviceLocator;
    }

    public static void Main(string[] args)
    {

    }
}