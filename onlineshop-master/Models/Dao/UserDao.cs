using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class UserDao
    {
        OnlineShopDbContext db = null;
        public UserDao()
        {
            db = new OnlineShopDbContext();
        }

        public long Insert(User newUser)
        {
            db.Users.Add(newUser);
            db.SaveChanges();
            return newUser.ID;
        }

        public int Login(string userName, string password)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == userName && x.Password == password);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (!result.Status)
                {
                    return -1;
                }
                else
                {
                    if(result.Password == password)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }
        }

        public User GetById(string Username)
        {
            return db.Users.SingleOrDefault(x => x.UserName == Username);
        }
    }
}
