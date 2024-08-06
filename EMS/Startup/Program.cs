using Employee_Management.EMS.Core.Implementations;
using Employee_Management.EMS.Core.Interfaces;
using Employee_Management.EMS.MenuManagement.MenuData;
using Employee_Management.EMS.MenuManagement.MenuDisplays;
using Employee_Management.EMS.MenuManagement.MenuServices;
using Employee_Management.EMS.UserInputChecks.IntChecks;
using Employee_Management.EMS.UserInputChecks.RangeChecks;
using Employee_Management.EMS.UserInputChecks.RequirementChecks;
using Employee_Management.EMS.UserInterface;
using Microsoft.Extensions.DependencyInjection;

class Program 
{
    public static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        var serviceProvider = serviceCollection.BuildServiceProvider();
        var userInterface = serviceProvider.GetService<UserInterface>();
        userInterface.Start();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<UserInterface>();
        services.AddSingleton<MainMenuList>();
        services.AddSingleton<SearchMenuList>();
        services.AddSingleton<MainMenuDisplay>();
        services.AddSingleton<SearchMenuDisplay>();
        services.AddSingleton<IntCheck>();
        services.AddSingleton<RangeCheck>();
        services.AddSingleton<RequirementCheck>();
        services.AddSingleton<MainMenuServices>();
        services.AddSingleton<IInputChecks, InputChecks>();
        services.AddSingleton<IDisplays, Displays>();
        services.AddSingleton<IData, Data>();
        services.AddSingleton<IServices, Services>();
    }
}
