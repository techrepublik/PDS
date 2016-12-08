using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class AddressManagement
    {
        public static DataRepository<Address> _d;

        public static int Save(Address address)
        {
            var a = new Address
            {
                AddressNo = address.AddressNo,
                PersonnelNo = address.PersonnelNo,
                AddressTypeNo = address.AddressTypeNo,
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                MunicipalityNo = address.MunicipalityNo,
                IsActive = address.IsActive,
                modifieddate = address.modifieddate
            };

            using (_d = new DataRepository<Address>())
            {
                if (address.AddressNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.AddressNo;
        }

        public static bool Delete(Address address)
        {
            using (_d = new DataRepository<Address>())
            {
                _d.Delete(address);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Address>())
            {
                _d.Delete(d => d.AddressNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Address> GetAll()
        {
            using (_d = new DataRepository<Address>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.GetAll().OrderByDescending(o => o.MunicipalityNo).ToList();
            }
        }
    }
}
