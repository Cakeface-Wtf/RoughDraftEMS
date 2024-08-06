using Employee_Management.EMS.UserInputChecks.IntChecks;
using Employee_Management.EMS.UserInputChecks.RangeChecks;
using Employee_Management.EMS.Utility;

namespace Employee_Management.EMS.UserInputChecks.RequirementChecks
{
    public class RequirementCheck : IRequirementCheck 
    {
        private readonly IntCheck _intCheck;
        private readonly RangeCheck _rangeCheck;

        public RequirementCheck(IntCheck intCheck, RangeCheck rangeCheck)
        {
            _intCheck = intCheck;
            _rangeCheck = rangeCheck;
        }

        public int InputCheckRequirement(string input, int count, Func<int, bool> additionalChecks = null) 
        {
            int attempts = 0;

            try
            {
                while (attempts < 5)
                {
                    if (_intCheck.InputCheckInt(input, out int validInput) &&
                        _rangeCheck.InputCheckRange(validInput, 0, count) &&
                        (additionalChecks == null || additionalChecks(validInput)))
                    {
                        return validInput;
                    }
                    attempts++;
                    if (attempts < 5)
                    {
                        Console.WriteLine($"Invalid input. Please use a number between 1 - {count}:");
                        input = Console.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
                ExitProgram.Exit(1);
            }

            throw new ArgumentException("Maximum attempts reached." + Environment.NewLine);

        }
    }
}

