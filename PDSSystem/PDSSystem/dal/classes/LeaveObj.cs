using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.data;

namespace PDSSystem.dal.classes
{
    public class LeaveObj : LeaveApplication
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixName { get; set; }
        public string PersonnelName {
            get { return String.Format("{0}, {1} {2}", LastName, FirstName, MiddleName); }
        }
        public string LeaveName { get; set; }
        public string LeaveType { get; set; }

    }
}
