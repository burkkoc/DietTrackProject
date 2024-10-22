using EFDiyet2.DAL.Context;
using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.DAL.Repository.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        
        protected readonly EFDiyet2DbContext _db;
        protected DbSet<T> entities;
        public Repository(EFDiyet2DbContext db)
        {
            _db = db;
            entities = _db.Set<T>();
        }

        public void Insert(T entity)
        {
            entity.DataStatus = DataStatus.Inserted;
            entity.Created= DateTime.Now;
            if (entity.UCreated == null)
            {
                entity.UCreated = DateTime.Now;
            }
            
            entities.Add(entity);
            _db.SaveChanges();

        }
        public void Delete(T entity)
        {
           
            entity.DataStatus = DataStatus.Deleted;
            entity.Deleted = DateTime.Now;
            Update(entity);
        }

        public void Update(T entity)
        {
            entity.DataStatus = entity.DataStatus != DataStatus.Deleted
               ? DataStatus.Modified : DataStatus.Deleted;

            entity.Updated = DateTime.Now;
            //var createdBefore = entity.Created;

            using (var dbContext = new EFDiyet2DbContext())
            {
                var existingEntity = dbContext.Set<T>().Find(entity.Id);
                if (existingEntity != null)
                {
                    entity.Created = existingEntity.Created;
                    dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);


                    dbContext.SaveChanges();
                }
            }
            //var existingEntity = entities.Local.FirstOrDefault(e => e.Id == entity.Id);

            //if (existingEntity == null)
            //{
            //    // Eğer varlık yerel olarak takip edilmiyorsa yerel takip edilenlere ekle
            //    entities.Attach(entity);
            //    _db.Entry(entity).State = EntityState.Modified;
            //}
            //else
            //{
            //    // Eğer varlık yerel olarak takip ediliyorsa yerel takip edilen varlığı güncelle
            //    _db.Entry(existingEntity).CurrentValues.SetValues(entity);
            //}

            //_db.SaveChanges();

            //if (entity is FoodCategory || entity is Food || entity is Meal || entity is UserFood)
            //{
            //    var existingEntity = entities.Local.FirstOrDefault(e => e.Id == entity.Id);

            //    if (existingEntity == null)
            //    {
            //        _db.Entry(entity).State = EntityState.Modified;
            //    }
            //    else
            //    {
            //        // Eğer varsa, mevcut takip edilen varlığı güncelle
            //        _db.Entry(existingEntity).CurrentValues.SetValues(entity);
            //    }
            //}
            //else
            //{
            //    _db.Update(entity);
            //}

            //_db.SaveChanges();
        }
        public void Remove(T entity)
        {
            using (var dbContext = new EFDiyet2DbContext()) // DbContext türünü uygun şekilde değiştirin
            {
                var existingEntity = dbContext.Set<T>().Find(entity.Id);

                if (existingEntity != null)
                {
                    dbContext.Set<T>().Remove(existingEntity);
                    dbContext.SaveChanges();
                }
            }

            _db.SaveChanges();
            //if (typeof(T) == typeof(Food) || typeof(T) == typeof(Meal) || typeof(T) == typeof(FoodCategory))
            //{
            //    var existingEntity = entities.Local.FirstOrDefault(e => e.Id == entity.Id);

            //    if (existingEntity == null)
            //    {
            //        // Eğer varlık yerel olarak takip edilmiyorsa yerel takip edilenlere ekle
            //        entities.Attach(entity);
            //        _db.Entry(entity).State = EntityState.Modified;
            //    }
            //    else
            //    {
            //        // Eğer varlık yerel olarak takip ediliyorsa yerel takip edilenlerden kaldır
            //        entities.Remove(existingEntity);
            //    }
            //}
            //else
            //{
            //    var existingEntity = entities.Local.FirstOrDefault(e => e.Id == entity.Id);

            //    if (existingEntity == null)
            //    {
            //        // Eğer varlık yerel olarak takip edilmiyorsa yerel takip edilenlere ekle
            //        entities.Attach(entity);
            //        _db.Entry(entity).State = EntityState.Deleted;
            //    }
            //    else
            //    {
            //        // Eğer varlık yerel olarak takip ediliyorsa yerel takip edilenlerden kaldır
            //        entities.Remove(existingEntity);
            //    }
            //}

        }
        
        public void UpdateDeletedValues(T entity)
        {
            entity.DataStatus = entity.DataStatus != DataStatus.Deleted ? DataStatus.Modified : DataStatus.Deleted;
            entity.Updated = DateTime.Now;
            entities.Update(entity);
            _db.SaveChanges();
            //?
        }

        public virtual IQueryable<T> GetAll()
        {
            return entities.Where(x => x.DataStatus != DataStatus.Deleted).AsNoTracking();
        }
        public virtual IQueryable<T> GetAllById(int id)
        {
            return entities.Where(x => x.DataStatus != DataStatus.Deleted).Where(x => x.Id == id).AsNoTracking();
        }
        public T GetById(int id)
        {
            return entities.AsNoTracking().FirstOrDefault(x => x.Id == id && x.DataStatus != DataStatus.Deleted);
        }
        public T GetDeletedById(int id)
        {
            return entities.AsNoTracking().FirstOrDefault(x => x.Id == id && x.DataStatus == DataStatus.Deleted);

        }


        public IQueryable<T> Search(Expression<Func<T, bool>> predicate)
        {
            var all = entities.Where(x=>x.DataStatus!= DataStatus.Deleted).AsNoTracking();
            return all.Where(predicate);
        }
        public void Attach(T entity) //ben ekledim
        {
            var entry = _db.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                entities.Attach(entity);
            }
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
        public void DetachEntity(T entity) //ben ekledim
        {
            var entry = _db.ChangeTracker.Entries<T>().FirstOrDefault(e => e.Entity == entity);

        
        }

    }
}

   