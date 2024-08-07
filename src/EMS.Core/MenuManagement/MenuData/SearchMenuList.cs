namespace EMS.Core.MenuManagement.MenuData
{
    public class SearchMenuList : IMenuData
    {
        private readonly List<string> _searchOptions = new List<string>()
        {
            "Employee ID",
            "Employee Name"
        };

        public List<string> GetOptions()
        {
            return _searchOptions;
        }
    }
}
