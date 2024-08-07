using EMS.Core.MenuManagement.MenuServices;
using EMS.Core.Interfaces;

namespace EMS.Core.Implementations
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
