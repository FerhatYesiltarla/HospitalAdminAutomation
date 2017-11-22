using DAL.ORM.Context;
using DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Base
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private HospitalAutomationContext context;
        protected DbSet<T> dbset;

        public BaseRepository()
        {
            context = new HospitalAutomationContext();
            dbset = context.Set<T>();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        #region Insert
        public virtual int Insert(T entity)
        {
            try
            {
                entity.InsertDate = DateTime.Now;
                entity.IsDeleted = false;
                dbset.Add(entity);
                return Save();
            }
            catch (Exception)
            {
                return 0;               
            }
        }

        public virtual int InsertMany(ICollection<T> entities)
        {
            try
            {
                foreach (var entity in entities)
                {
                    entity.InsertDate = DateTime.Now;
                    entity.IsDeleted = false;
                    dbset.Add(entity);
                }

                return Save();
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion

        #region Update
        public virtual int Update(T updatedEntity)
        {
            if (updatedEntity.Id == 0)
                return 0;

            try
            {
                T oldEntity = dbset.Find(updatedEntity.Id);

                if (oldEntity == null)
                    return 0;

                updatedEntity.UpdateDate = DateTime.Now;
                updatedEntity.InsertDate = oldEntity.InsertDate;
                updatedEntity.IsDeleted = oldEntity.IsDeleted;

                context.Entry(oldEntity).CurrentValues.SetValues(updatedEntity);

                return Save();
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion

        #region Delete

        public virtual int Delete(int? Id)
        {
            T entity = dbset.Find(Id);
            entity.DeleteDate = DateTime.Now;
            entity.IsDeleted = true;
            
            return Save();
        }

        public virtual int SuperDelete(int? Id)
        {
            T entity = dbset.Find(Id);
            entity.DeleteDate = DateTime.Now;
            entity.IsDeleted = true;

            return Save();
        }

        public virtual int Revert(int? Id)
        {
            var model = dbset.Find(Id);
            model.IsDeleted = false;

            return Save();
        }

        #endregion

        #region Select
        public List<T> SelectAll()
        {
            return dbset.ToList();
        }

        public List<T> SelectByState(bool? deleteState = false )
        {
            return dbset.Where(x => x.IsDeleted == deleteState).ToList();
        }

        public List<T> SelectByCondition(Expression<Func<T,bool>> predicate)
        {
            return dbset.Where(predicate).ToList();
        }

        public T SelectFirst(Expression<Func<T, bool>> predicate)
        {
            return dbset.FirstOrDefault(predicate);
        }
        #endregion
    }
}
