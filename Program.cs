using Employee_Management.EMS.Core;
using Employee_Management.EMS.MenuManagement.MenuDisplays;
using Employee_Management.EMS.MenuManagement.MenuServices;
using Employee_Management.EMS.UserInterface;

class Program
{
    static void Main()
    {
        MainMenuOptions menuOptions = new MainMenuOptions();

        MainMenuDisplay mainMenu = new MainMenuDisplay(menuOptions);
        MainMenuDisplay subMenu = new MainMenuDisplay(menuOptions);

        ApplicationService applicationService = new ApplicationService(mainMenu, subMenu);

        UI ui = new UI(applicationService);
        ui.StartUI();
    }
}
