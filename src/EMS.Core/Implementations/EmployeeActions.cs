using EMS.Core.MenuManagement.MenuActions;
using EMS.Core.Interfaces;
using EMS.Core.MenuManagement.MenuActions;

namespace EMS.Core.Implementations
{
    public class EmployeeActions : IEmployeeActions
    {
        private readonly AddEmployeeAction _addEmployeeAction;
        private readonly DeleteEmployeeAction _deleteEmployeeAction;
        private readonly EditEmployeeAction _editEmployeeAction;
        private readonly SearchEmployeeAction _searchEmployeeAction;

        public EmployeeActions(AddEmployeeAction addEmployeeAction, DeleteEmployeeAction deleteEmployeeAction, EditEmployeeAction editEmployeeAction, SearchEmployeeAction searchEmployeeAction)
        {
            _addEmployeeAction = addEmployeeAction;
            _deleteEmployeeAction = deleteEmployeeAction;
            _editEmployeeAction = editEmployeeAction;
            _searchEmployeeAction = searchEmployeeAction;
        }

        public void AddEmployee() //Add new employee
        {
            _addEmployeeAction.Execute();
        }

        public void DeleteEmployee() //Delete exsisting employee
        {
            _deleteEmployeeAction.Execute();
        }

        public void EditEmployee() //Edit exsisting employee
        {
            _editEmployeeAction.Execute();
        }

        public void SearchEmployee() //Search existing employee
        {
            _searchEmployeeAction.Execute();
        }
    }
}
