using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.classes
{
    public class LeaveCreditObj
    {
        public int PersonnelNo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SuffixName { get; set; }
        public string FullName {
            get { return String.Format("{0}, {1} {2}", LastName.ToUpper(), FirstName, MiddleName); }
        }
        public double? VacationEarned { get; set; }
        public double? SickEarned { get; set; }
        public double? VacationDeduction1 { get; set; }
        public double? VacationDeduction2 { get; set; }
        public double? SickDeduction1 { get; set; }
        public double? SickDeduction2 { get; set; }
    }
}
