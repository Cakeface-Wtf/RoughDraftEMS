namespace Employee_Management.EMS.UserInputChecks.IntChecks
{
    public class IntCheck : IIntCheck
    {
        public bool InputCheckInt(string input, out int result) 
        {
            return int.TryParse(input, out result);
        }
    }
}
