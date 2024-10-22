using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.DAL.Repository.Abstract
{
    public interface IRepository<T>
    {
        public void Insert(T entity);

        public void Update(T entity);

        public void UpdateDeletedValues(T entity);

        public void Delete(T entity);

        public void Remove(T entity);

        public IQueryable<T> GetAll();

        public T GetById(int id);

        public T GetDeletedById(int id);

        public IQueryable<T> Search(Expression<Func<T, bool>> predicate);    
        public void SaveChanges();
        public void DetachEntity(T entity);//ben ekledim

        public void Attach(T entity); //ben ekledim
    }
    //public void Insert(T entity);

    //public void Update(T entity);

    //public void UpdateDeletedValues(T entity);

    //public void Delete(T entity);

    //public IQueryable<T> GetAll();

        //public void Remove(T entity);

        //public T GetById(int id);

        //public T GetDeletedById(int id);

        //public IQueryable<T> Search(Expression<Func<T, bool>> predicate);
    
}
