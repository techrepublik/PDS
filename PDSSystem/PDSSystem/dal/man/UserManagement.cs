using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSSystem.dal.data;
using PDSSystem.dal.repo;

namespace PDSSystem.dal.man
{
    public class UserManagement
    {
        public static DataRepository<User> _d;

        public static int Save(User user)
        {
            var a = new User
            {
                UserNo = user.UserNo,
                UserName = user.UserName,
                UserLevel = user.UserLevel,
                Password = user.Password,
                IsActive = user.IsActive
            };

            using (_d = new DataRepository<User>())
            {
                if (user.UserNo > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.UserNo;
        }

        public static bool Delete(User user)
        {
            using (_d = new DataRepository<User>())
            {
                _d.Delete(user);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<User>())
            {
                _d.Delete(d => d.UserNo == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<User> GetAll()
        {
            using (_d = new DataRepository<User>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }

        public static User ValiDateUser(string uName, string pWord)
        {
            using (_d = new DataRepository<User>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.Single(u => u.UserName == uName && u.Password == pWord);
            }
        }
    }
}
