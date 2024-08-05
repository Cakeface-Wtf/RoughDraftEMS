using Employee_Management.EMS.UserInputChecks.IntChecks;
using Employee_Management.EMS.UserInputChecks.RangeChecks;
using Employee_Management.EMS.UserInputChecks.RequirementChecks;
using Employee_Management.EMS.MenuManagement.MenuDisplays;

namespace Employee_Management.EMS.Core
{
    public class ApplicationService : IApplicationService
    {
        private readonly IMenuDisplay _mainMenu;
        private readonly IMenuDisplay _subMenu;
        private readonly IIntCheck _checkInt;
        private readonly IRangeCheck _rangeChecker;
        private readonly IRequirementCheck _requirementChecker;

        public ApplicationService(IMenuDisplay mainMenu, IMenuDisplay subMenu, IIntCheck checkInt, IRangeCheck rangeChecker, IRequirementCheck requirementChecker)
        {
            _mainMenu = mainMenu;
            _subMenu = subMenu;
            _checkInt = checkInt;
            _rangeChecker = rangeChecker;
            _requirementChecker = requirementChecker;
        }

        public void DisplayMainMenu()
        {
            _mainMenu.DisplayOptions();
        }

        public void DisplaySearchEditMenu()
        {
            _subMenu.DisplayOptions();
        }

        public bool CheckInt(string input, out int result)
        {
            return _checkInt.InputCheckInt(input, out result);
        }

        public bool CheckRange(int input, int x, int y)
        {
            return _rangeChecker.InputCheckRange(input, x, y);
        }

        public int CheckRequirement(string input, Func<int, bool> additionalChecks = null)
        {
            return _requirementChecker.InputCheckRequirement(input, additionalChecks);
        }
    }
}
