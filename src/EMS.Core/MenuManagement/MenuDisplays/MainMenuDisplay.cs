using EMS.Core.MenuManagement.MenuData;

namespace EMS.Core.MenuManagement.MenuDisplays
{
    public class MainMenuDisplay : IMenuDisplay
    {
        private readonly MainMenuList _mainMenuList;

        public MainMenuDisplay(MainMenuList mainMenuList)
        {
            _mainMenuList = mainMenuList;
        }


        public void DisplayOptions() 
        {
            int i = 1;
            foreach (var option in _mainMenuList.GetOptions())
            {
                Console.WriteLine($"{i++}.) {option}");
            }
        }
    }
}
