using System;
using System.Collections.Generic;
using System.Linq;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;
using System.Text;
using System.Threading.Tasks;

namespace PDSSystem.dal.man
{
    public class AddressTypeManagement
    {
        public static DataRepository<AddressType> _d;

        public static int Save(AddressType addressType)
        {
            var a = new AddressType
            {
                AddressTypeNo = addressType.AddressTypeNo,
                AddressTypeName = addressType.AddressTypeName,
                modifieddate = addressType.modifieddate
            };

            using (_d = new DataRepository<AddressType>())
            {
                if (addressType.AddressTypeNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.AddressTypeNo;
        }

        public static bool Delete(AddressType addressType)
        {
            using (_d = new DataRepository<AddressType>())
            {
                _d.Delete(addressType);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<AddressType>())
            {
                _d.Delete(d => d.AddressTypeNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<AddressType> GetAll()
        {
            using (_d = new DataRepository<AddressType>())
            {
                _d.LazyLoadingEnabled = true;
                return _d.GetAll().OrderBy(o => o.AddressTypeName).ToList();
            }
        }
    }
}
