using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class ChildrenManagement
    {
        public static DataRepository<Children> _d;

        public static int Save(Children children)
        {
            var a = new Children
            {
                ChildrenNo = children.ChildrenNo,
                SpouseNo = children.SpouseNo,
                ChildrenLastName = children.ChildrenLastName,
                ChildrenFirstName = children.ChildrenFirstName,
                ChildrenMiddleName = children.ChildrenMiddleName,
                ChildrenBirthDate = children.ChildrenBirthDate,
                modifieddate = children.modifieddate
            };

            using (_d = new DataRepository<Children>())
            {
                if (children.ChildrenNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.ChildrenNo;
        }

        public static bool Delete(Children children)
        {
            using (_d = new DataRepository<Children>())
            {
                _d.Delete(children);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Children>())
            {
                _d.Delete(d => d.ChildrenNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Children> GetAll()
        {
            using (_d = new DataRepository<Children>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.GetAll().OrderByDescending(o => o.ChildrenBirthDate).ToList();
            }
        }

        public static List<Children> GetAll(int iId)
        {
            using (_d = new DataRepository<Children>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.Find(f => f.SpouseNo == iId).OrderByDescending(o => o.ChildrenBirthDate).ToList();
            }
        }
    }
}
