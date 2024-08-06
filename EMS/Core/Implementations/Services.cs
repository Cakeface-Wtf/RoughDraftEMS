using Employee_Management.EMS.Core.Interfaces;
using Employee_Management.EMS.MenuManagement.MenuServices;

namespace Employee_Management.EMS.Core.Implementations
{
    public class Services : IServices
    {
        private readonly MainMenuServices _mainMenuServices;

        public Services(MainMenuServices mainMenuServices)
        {
            _mainMenuServices = mainMenuServices;
        }

        public void HandleMainMenuSelection(int selection) //Execute users main menu selection
        {
            _mainMenuServices.MenuService(selection);
        }
    }
}
