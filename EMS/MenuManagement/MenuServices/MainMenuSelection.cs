using Employee_Management.EMS.MenuManagement.MenuActions;
using Employee_Management.EMS.Utility;

namespace Employee_Management.EMS.MenuManagement.MenuServices
{
    public class MainMenuSelection
    {
        private readonly Dictionary<int, IMenuAction> _menuActions;

        public MainMenuSelection()
        {
            _menuActions = new Dictionary<int, IMenuAction>
            {
                { 1, new SearchEditEmployeeAction() },
                { 2, new AddEmployeeAction() },
                { 3, new OtherAction() }
            };
        }

        public void MainMenuAction(int selection)
        {
            if (_menuActions.TryGetValue(selection, out IMenuAction action))
            {
                action.Execute();
            }
            else
            {
                Console.WriteLine("Something went wrong...");
                ExitProgram.Exit(1);
            }
        }
    }
}
