using Microsoft.Extensions.DependencyInjection;
using Calculations;
namespace SimpleCalculator;

public class Startup
{
    public static IServiceProvider Configure()
    {
        var serviceCollection = new ServiceCollection()
            .AddScoped<IAddition, Addition>()
            .AddScoped<IDivision, Division>()
            .AddScoped<IMultiplication, Multiplication>()
            .AddScoped<ISubtraction, Subtraction>()
            .AddScoped<IUserInputValidation, UserConsoleInputValidation>();

        return serviceCollection.BuildServiceProvider();
    }
}
