using EMS.Core.MenuManagement.MenuActions;
using EMS.Core.Utility;

namespace EMS.Core.MenuManagement.MenuServices
{
    public class MainMenuServices : IMenuServices
    {
        private readonly Dictionary<int, IMenuAction> _menuActions;

        public MainMenuServices()
        {
            _menuActions = new Dictionary<int, IMenuAction>
            {
                { 1, new SearchEmployeeAction() },
                { 2, new AddEmployeeAction() },
                { 3, new GenerateListAction() }
            };
        }

        public void MenuService(int selection)
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
