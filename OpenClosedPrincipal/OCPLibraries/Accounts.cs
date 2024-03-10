using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibraries
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IPersonModel person)
        {
            EmployeeModel employee = new EmployeeModel();
            employee.firstName = person.firstName;
            employee.lastName = person.lastName;
            employee.email = $"{person.firstName.Substring(0, 1)}{person.lastName}@acme.com";
            return employee;
        }
    }
}
