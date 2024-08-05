using Employee_Management.EMS.MenuManagement.MenuServices;

namespace Employee_Management.EMS.MenuManagement.MenuDisplays
{
    public class MainMenuDisplay : IMenuDisplay
    {
        private readonly MainMenuOptions _menuOptions;

        public MainMenuDisplay(MainMenuOptions menuOptions)
        {
            _menuOptions = menuOptions;
        }


        public void DisplayOptions() //Display MainMenu
        {
            int i = 0;
            foreach (var option in _menuOptions.Options)
            {
                Console.WriteLine($"{i++ + 1}.) {option}");
            }
        }
    }
}
