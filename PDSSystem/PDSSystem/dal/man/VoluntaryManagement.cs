using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class VoluntaryManagement
    {
        public static DataRepository<Voluntary> _d;

        public static int Save(Voluntary voluntary)
        {
            var a = new Voluntary
            {
                VoluntaryNo = voluntary.VoluntaryNo,
                PersonnelNo = voluntary.PersonnelNo,
                VoluntaryOrganization = voluntary.VoluntaryOrganization,
                VoluntaryDate1 = voluntary.VoluntaryDate1,
                VoluntaryDate2 = voluntary.VoluntaryDate2,
                VoluntaryNoHours = voluntary.VoluntaryNoHours,
                VoluntaryPosition = voluntary.VoluntaryPosition,
                IsActive = voluntary.IsActive,
                modifieddate = voluntary.modifieddate
            };

            using (_d = new DataRepository<Voluntary>())
            {
                if (voluntary.VoluntaryNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.VoluntaryNo;
        }

        public static bool Delete(Voluntary voluntary)
        {
            using (_d = new DataRepository<Voluntary>())
            {
                _d.Delete(voluntary);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Voluntary>())
            {
                _d.Delete(d => d.VoluntaryNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Voluntary> GetAll()
        {
            using (_d = new DataRepository<Voluntary>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().OrderByDescending(o => o.VoluntaryDate1).ToList();
            }
        }

        public static List<Voluntary> GetAll(int iId)
        {
            using (_d = new DataRepository<Voluntary>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).OrderByDescending(o => o.VoluntaryDate1).ToList();
            }
        }
    }
}
