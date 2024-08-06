namespace Employee_Management.EMS.UserInputChecks.RangeChecks
{
    public class RangeCheck : IRangeCheck
    {
        public bool InputCheckRange(int input, int x, int y) 
        {
            return input > x && input <= y;
        }
    }
}
