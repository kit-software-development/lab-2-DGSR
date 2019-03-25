using System;
using Practice.Common;
using Practice.Organization;
using Practice.HR.Events;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о сотруднике.
    /// </summary>
    internal class Employee : AbstractPerson, IEmployee
    {
        /*
         * TODO #5: Реализуйте интерфейс IEmployee для класса Employee
         */
         private IDepartment _department;
         public Employee(IName name, IDepartment department): base(name)
         {
            Department = department;
         }
        
        public IDepartment Department
        {
            get => _department;
            set
            {
                ValueChangeEventArgs<IDepartment> args = new ValueChangeEventArgs<IDepartment>(_department);
                _department = value;
                DepartmentChange?.Invoke(this, args);
            }
        }
        public event EventHandler<ValueChangeEventArgs<IDepartment>> DepartmentChange;
    }
}
