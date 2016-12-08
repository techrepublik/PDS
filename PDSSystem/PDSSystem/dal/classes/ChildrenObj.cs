using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.data;

namespace PDSSystem.dal.classes
{
    public class ChildrenObj : Children
    {
        public string FullName
        {
            get { return String.Format("{0}, {1} {2}", ChildrenLastName, ChildrenFirstName, ChildrenMiddleName); } 
        }
    }
}
