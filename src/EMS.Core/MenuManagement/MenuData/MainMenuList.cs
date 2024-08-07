namespace EMS.Core.MenuManagement.MenuData
{
    public class MainMenuList : IMenuData
    {
        private readonly List<string> _mainMenuOptions = new List<string>()
        {
            "Search/Edit Employee",
            "Add Employee",
            "Generate List"
        };

        public List<string> GetOptions()
        {
            return _mainMenuOptions;
        }
    }
}
