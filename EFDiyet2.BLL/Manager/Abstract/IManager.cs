using EFDiyet2.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.BLL.Manager.Abstract
{
    public interface IManager<TModel,TEntity> where TModel : class
    {
        //User-Admin
        void Add(TModel model);
        
        void Update(TModel model);
        
        void Delete(TModel model);//Soft-Delete

        void Remove(TModel model);//Hard-Delete
        
        TModel GetById(int id);
        
        List<TModel> GetAll();
      
        TModel GetDeletedById(int id);
        
        List<TModel> Search(Expression<Func<TModel, bool>> predicate);

        List<TModel> GetAllById(int id);
        public void SaveChanges();

    }
    //public interface IManager<TModel, TEntity> where TModel : class
    //{
    //    // Yeni model ekler
    //    void Add(TModel model);

    //    // Modeli günceller
    //    void Update(TModel model);

    //    // Modeli siler (soft-delete)
    //    void Delete(TModel model);

    //    // Modeli tamamen kaldırır (hard-delete)
    //    void Remove(TModel model);

    //    // Id'ye göre model getirir
    //    TModel GetById(int id);

    //    // Silinmemiş tüm modelleri getirir
    //    List<TModel> GetAll();

    //    // Silinmiş bir modeli Id'ye göre getirir
    //    TModel GetDeletedById(int id);

    //    // Belirli bir koşula uyan modelleri getirir
    //    List<TModel> Search(Expression<Func<TModel, bool>> predicate);
    //    void SaveChanges();
    //}
}
