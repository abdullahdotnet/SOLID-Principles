using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibraries
{
    public class ManagerModel : IPersonModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public IAccounts accountProcessor { get; set; } = new ManagerAccount();
    }
}
