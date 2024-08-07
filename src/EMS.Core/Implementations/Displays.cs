using EMS.Core.MenuManagement.MenuDisplays;
using EMS.Core.Interfaces;

namespace EMS.Core.Implementations
{
    public class Displays : IDisplays
    {
        private readonly MainMenuDisplay _mainMenuDisplay;
        private readonly SearchMenuDisplay _searchMenuDisplay;

        public Displays(MainMenuDisplay mainMenuDisplay, SearchMenuDisplay searchMenuDisplay)
        {
            _mainMenuDisplay = mainMenuDisplay;
            _searchMenuDisplay = searchMenuDisplay;
        }

        public void DisplayMainMenu() //Displays user main menu options
        {
            _mainMenuDisplay.DisplayOptions();
        }

        public void DisplaySearchMenu() //Displays user search menu options
        {
            _searchMenuDisplay.DisplayOptions();
        }
    }
}
