using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class OrganizationManagement
    {
        public static DataRepository<Organization> _d;

        public static int Save(Organization organization)
        {
            var a = new Organization
            {
                OrganizationNo = organization.OrganizationNo,
                PersonnelNo = organization.PersonnelNo,
                OrganizationName = organization.OrganizationName,
                modifieddate = organization.modifieddate
            };

            using (_d = new DataRepository<Organization>())
            {
                if (organization.OrganizationNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.OrganizationNo;
        }

        public static bool Delete(Organization organization)
        {
            using (_d = new DataRepository<Organization>())
            {
                _d.Delete(organization);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Organization>())
            {
                _d.Delete(d => d.OrganizationNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Organization> GetAll()
        {
            using (_d = new DataRepository<Organization>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderBy(o => o.OrganizationName).ToList();
            }
        }

        public static List<Organization> GetAll(int iId)
        {
            using (_d = new DataRepository<Organization>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).OrderBy(o => o.OrganizationName).ToList();
            }
        }
    }
}
