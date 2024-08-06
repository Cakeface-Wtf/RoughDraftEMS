namespace Employee_Management.EMS.UserInputChecks.RequirementChecks
{
    public interface IRequirementCheck
    {
        public int InputCheckRequirement(string input, int count, Func<int, bool> additionalChecks = null);
    }
}
