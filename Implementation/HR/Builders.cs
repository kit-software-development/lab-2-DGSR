using Practice.Common;
using Practice.Organization;
using System;

namespace Practice.HR
{
    /// <summary>
    ///     Класс-фабрика, позволяющий получать экземпляры типов,
    ///     инкапсулированных на уровне библиотеки.
    /// </summary>
    public static class Builders
    {
        /// <summary>
        ///     Возвращает экземпляр "Строителя" клиентов.
        /// </summary>
        /// <returns>
        ///     Экземпляр типа IClientBuilder.
        /// </returns>
        private static IClientBuilder _clientBuilder;
        private static IEmployeeBuilder _employeeBuilder;
        public static IClientBuilder ClientBuilder()
        {
            /*
             * TODO #6: Реализовать фабричный метод ClientBuilder класса Builders
             */                
            return _clientBuilder ?? (_clientBuilder = new ClientBuild());
        }
        internal class ClientBuild : IClientBuilder
        {
            private IName _name;
            private float _discount;         
            public IClientBuilder Name(IName name)
            {
                _name = name;
                return this;
            }
            public IClientBuilder Name(string lastname, string firstname, string patronymic)
            {
                return Name(new Name { Surname = lastname, FirstName = firstname, Patronymic = patronymic, });
            }
            public IClientBuilder Discount(float discount)
            {
                _discount = discount;
                return this;
            }
            public IClient Build()
            {
                var client = new Client(_name, _discount);
                return client;
            }
        }
        /// <summary>
        ///     Возвращает экземпляр "Строителя" сотудников.
        /// </summary>
        /// <returns>
        ///     Возвращает экземпляр типа IEmployeeBuilder.
        /// </returns>
        public static IEmployeeBuilder EmployeeBuilder()
        {
            /*
             * TODO #7: Реализовать фабричный метод EmployeeBuilder класса Builders
             */
            return _employeeBuilder ?? (_employeeBuilder = new EmployeeBuild());
        }
        
        internal class EmployeeBuild: IEmployeeBuilder
        {
            private IName _name;
            private IDepartment _department;
            public IEmployeeBuilder Name(IName name)
            {
                _name = name;
                return this;
            }
            public IEmployeeBuilder Name(string lastname, string firstname, string patronymic)
            {
                return Name(new Name {  Surname = lastname, FirstName = firstname, Patronymic = patronymic, });
            }
            public IEmployeeBuilder Department(IDepartment department)
            {
                _department = department;
                return this;
            }
            public IEmployeeBuilder Department(string department)
            {
                return Department(new Department(department));
            }
            public IEmployee Build()
            {
                var employee = new Employee (_name,_department);
                return employee;
            }
        }
    }
}
