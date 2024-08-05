using Employee_Management.EMS.Core;
using Employee_Management.EMS.MenuManagement.MenuServices;
using Employee_Management.EMS.Utility;

namespace Employee_Management.EMS.UserInputChecks.RequirementChecks
{
    public class RequirementCheck : IRequirementCheck //Validate all checks
    {
        private readonly ApplicationService _applicationService;
        private readonly MainMenuOptions _menuOptions;

        public RequirementCheck(ApplicationService applicationService, MainMenuOptions menuOptions)
        {
            _applicationService = applicationService;
            _menuOptions = menuOptions;
        }


        public int InputCheckRequirement(string input, Func<int, bool> additionalChecks = null)
        {
            int attempts = 0;

            try
            {
                while (attempts < 5)
                {
                    if (_applicationService.CheckInt(input, out int validInput) &&
                        _applicationService.CheckRange(validInput, 0, _menuOptions.Options.Count) &&
                        (additionalChecks == null || additionalChecks(validInput)))
                    {
                        return validInput;
                    }
                    attempts++;
                    if (attempts < 5)
                    {
                        Console.WriteLine($"Invalid input. Please use a number between 1 - {_menuOptions.Options.Count}:");
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

