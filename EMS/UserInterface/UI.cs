using Employee_Management.EMS.Core;
using Employee_Management.EMS.MenuManagement.MenuServices;

namespace Employee_Management.EMS.UserInterface
{
    public class UI
    {
        private readonly ApplicationService _applicationService;
        private readonly MainMenuOptions _menuOptions;

        public UI(ApplicationService applicationService, MainMenuOptions menuOptions)
        {
            _applicationService = applicationService;
            _menuOptions = menuOptions;
        }

        public void StartUI() //Start UserInterface
        {
            Console.WriteLine("Please select from the following options: 'Type 1 to choose Search/Edit'" + Environment.NewLine);

            _applicationService.DisplayMainMenu(); //Display list of user options.

            int validInput = _applicationService.CheckRequirement(Console.ReadLine()); //Validate user input.
        }
    }
}


