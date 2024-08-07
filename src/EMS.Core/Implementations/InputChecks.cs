using EMS.Core.UserInputChecks.IntChecks;
using EMS.Core.UserInputChecks.RangeChecks;
using EMS.Core.UserInputChecks.RequirementChecks;
using EMS.Core.Interfaces;

namespace EMS.Core.Implementations
{
    public class InputChecks : IInputChecks
    {
        private readonly IntCheck _intCheck;
        private readonly RangeCheck _rangeCheck;
        private readonly RequirementCheck _requirementCheck;

        public InputChecks(IntCheck intCheck, RangeCheck rangeCheck, RequirementCheck requirementCheck)
        {
            _intCheck = intCheck;
            _rangeCheck = rangeCheck;
            _requirementCheck = requirementCheck;
        }

        public bool CheckInt(string input, out int result) //TryParse to check for int.
        {
            return _intCheck.InputCheckInt(input, out result);
        }

        public bool CheckRange(int input, int x, int y) //Check if int is within range requirements. 
        {
            return _rangeCheck.InputCheckRange(input, x, y);
        }

        public int CheckRequirement(string input, int count, Func<int, bool> additionalCheck = null) //Check input and return validInput. Checks int, range and optional additional check.
        {
            return _requirementCheck.InputCheckRequirement(input, count, additionalCheck);
        }
    }
}
