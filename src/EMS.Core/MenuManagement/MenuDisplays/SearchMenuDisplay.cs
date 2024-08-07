using EMS.Core.MenuManagement.MenuData;

namespace EMS.Core.MenuManagement.MenuDisplays
{
    public class SearchMenuDisplay : IMenuDisplay
    {
        private readonly SearchMenuList _searchMenuList;

        public SearchMenuDisplay(SearchMenuList searchMenuList)
        {
            _searchMenuList = searchMenuList;
        }

        public void DisplayOptions() 
        {
            int i = 1;
            foreach (var option in _searchMenuList.GetOptions())
            {
                Console.WriteLine($"{i++}.) {option}");
            }
        }
    }
}
