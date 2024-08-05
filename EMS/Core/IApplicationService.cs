namespace Employee_Management.EMS.Core
{
    public interface IApplicationService //Remove Display methods.  Move them to another interface in core folder. 
    {
        void DisplayMainMenu();
        void DisplaySearchEditMenu();
        bool CheckInt(string input, out int result);
        bool CheckRange(int input, int x, int y);
        int CheckRequirement(string input, Func<int, bool> additionalChecks = null);
    }
}
