using EMS.Core.Interfaces;

namespace EMS.Core.UserInterface
{
    public class UserInterface
    {
        private readonly IInputChecks _inputChecks;
        private readonly IDisplays _displays;
        private readonly IData _data;
        private readonly IServices _services;

        public UserInterface(IInputChecks inputChecks, IDisplays displays, IData data, IServices services)
        {
            _inputChecks = inputChecks;
            _displays = displays;
            _data = data;
            _services = services;
        }

        public void Start() 
        {
            Console.WriteLine("Please select from the following options: 'Type 1 to choose Search/Edit'" + Environment.NewLine);

            _displays.DisplayMainMenu(); //Display list of user options.

            int validInput = _inputChecks.CheckRequirement(Console.ReadLine(), _data.GetMainMenuOptions().Count); //Validate user input.

            _services.HandleMainMenuSelection(validInput); //Handle user selection.
        }
    }
}


