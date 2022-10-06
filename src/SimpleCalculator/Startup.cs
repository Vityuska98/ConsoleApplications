using Calculations;
using Microsoft.Extensions.DependencyInjection;
namespace SimpleCalculator;

public class Startup
{
    public static IServiceProvider Congifure()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped<IAddition, Addition>();
        serviceCollection.AddScoped<IDivision, Division>();
        serviceCollection.AddScoped<IMultiplication, Multiplication>();
        serviceCollection.AddScoped<ISubtraction, Subtraction>();

        var serviceProvider = serviceCollection.BuildServiceProvider();
        
    }
}
