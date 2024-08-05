namespace Employee_Management.EMS.MenuManagement.MenuServices
{
    public class MainMenuOptions
    {
        private readonly List<string> _options = new List<string>()
        {
            "Search/Edit Employee",
            "Add Employee",
            "Other"
        };

        public List<string> Options => _options;
    }
}
