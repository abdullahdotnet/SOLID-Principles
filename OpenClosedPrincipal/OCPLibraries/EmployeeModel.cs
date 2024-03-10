using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibraries
{
    public class EmployeeModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public bool isManager { get; set; }
        public bool isExecutive { get; set; }
    }
}
