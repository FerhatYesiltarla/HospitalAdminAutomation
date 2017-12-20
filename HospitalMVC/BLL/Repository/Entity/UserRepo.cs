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

        public override int Insert(User entity)
        {
            try
            {
                if (!dbset.Any(x => x.Email == entity.Email))
                {
                    entity.InsertDate = DateTime.Now;
                    entity.IsDeleted = false;
                    entity.Role = "1";
                    dbset.Add(entity);
                    return Save();
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
