using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;

namespace PDSSystem.dal.man
{
    public class ReferencesManagement
    {
        public static DataRepository<Reference> _d;

        public static int Save(Reference reference)
        {
            var a = new Reference
            {
                ReferenceNo = reference.ReferenceNo,
                PersonnelNo = reference.PersonnelNo,
                ReferenceName = reference.ReferenceName,
                ReferenceAddress = reference.ReferenceAddress,
                ReferenceTelNo = reference.ReferenceTelNo,
                ReferenceIsAcive = reference.ReferenceIsAcive
            };

            using (_d = new DataRepository<Reference>())
            {
                if (reference.ReferenceNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.ReferenceNo;
        }

        public static bool Delete(Reference reference)
        {
            using (_d = new DataRepository<Reference>())
            {
                _d.Delete(reference);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Reference>())
            {
                _d.Delete(d => d.ReferenceNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Reference> GetAll()
        {
            using (_d = new DataRepository<Reference>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }

        public static List<Reference> GetAll(int iId)
        {
            using (_d = new DataRepository<Reference>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Find(f => f.PersonnelNo == iId).ToList();
            }
        }
    }
}
