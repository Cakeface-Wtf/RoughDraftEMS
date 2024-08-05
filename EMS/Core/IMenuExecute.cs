

namespace Employee_Management.EMS.Core
{
    public interface IMenuExecute //Put all menu executes here or just mainmenu? Other, searchedit, and whatever menus here or in their own space?  
    {
        void AddEmployee();
        void SearchEdit();
        void Other();
    }
}
