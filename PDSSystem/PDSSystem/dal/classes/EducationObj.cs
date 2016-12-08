using PDSSystem.dal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.classes
{
    public class EducationObj : Education
    {
        public string SchoolsName { get; set; }
        public string DegreesName { get; set; }
    }
}
