using EMS.Core.Implementations;
using EMS.Core.Interfaces;
using EMS.Core.MenuManagement.MenuData;
using EMS.Core.MenuManagement.MenuDisplays;
using EMS.Core.MenuManagement.MenuServices;
using EMS.Core.UserInputChecks.IntChecks;
using EMS.Core.UserInputChecks.RangeChecks;
using EMS.Core.UserInputChecks.RequirementChecks;
using EMS.Core.UserInterface;
using Microsoft.Extensions.DependencyInjection;
using static System.Runtime.InteropServices.JavaScript.JSType; //tf is this?

namespace EMS.Client
{
    internal class Program
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
}
