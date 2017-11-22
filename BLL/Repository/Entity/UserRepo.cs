using DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Entity
{
    public class UserRepo : Base.BaseRepository<User>
    {
        public bool CheckCredentials(string email, string password)
        {
            return dbset.Any(x => x.Email == email && x.Password == password);
        }

        public User FindByEmail(string email)
        {
            return dbset.FirstOrDefault(x => x.Email == email);
        }

        public bool ExistingUser(string email)
        {
            return dbset.Any(x => x.Email == email);
        }
    }
}
