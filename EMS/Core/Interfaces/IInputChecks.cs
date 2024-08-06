namespace Employee_Management.EMS.Core.Interfaces
{
    public interface IInputChecks
    {
        bool CheckInt(string input, out int result);
        bool CheckRange(int input, int x, int y);
        int CheckRequirement(string input, int count, Func<int, bool> additionalChecks = null);
    }
}
