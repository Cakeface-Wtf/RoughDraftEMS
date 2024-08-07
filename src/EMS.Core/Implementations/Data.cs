using EMS.Core.Interfaces;
using EMS.Core.MenuManagement.MenuData;

namespace EMS.Core.Implementations
{
    public class Data : IData
    {
        private readonly MainMenuList _mainMenuList;
        private readonly SearchMenuList _searchMenuList;

        public Data(MainMenuList mainMenuList, SearchMenuList searchMenuList)
        {
            _mainMenuList = mainMenuList;
            _searchMenuList = searchMenuList;
        }

        public List<string> GetMainMenuOptions() //Returns user main menu options
        {
            return _mainMenuList.GetOptions();
        }
        public List<string> GetSearchOptions() //Returns user search options
        {
            return _searchMenuList.GetOptions();
        }
    }
}
