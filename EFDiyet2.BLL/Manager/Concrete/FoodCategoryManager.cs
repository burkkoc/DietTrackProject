using EFDiyet2.BLL.Manager.Abstract;
using EFDiyet2.BLL.Models;
using EFDiyet2.DAL.Context;
using EFDiyet2.DAL.Entities;
using EFDiyet2.BLL.Manager.Abstract;
using EFDiyet2.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.BLL.Manager.Concrete
{
    public class FoodCategoryManager:Manager<FoodCategoryModel,FoodCategory>
    {
        public FoodCategoryManager()
        {
            _repository = new FoodCategoryRepository(new DAL.Context.EFDiyet2DbContext());
        }
    }
    //public class FoodCategoryManager : Manager<FoodCategoryModel, FoodCategory>
    //{
    //    public FoodCategoryManager(IRepository<FoodCategory> repository, IMapper mapper) : base(repository, mapper)
    //    {

    //    }

    //    public void Delete(int id)
    //    {
    //        try
    //        {
    //            FoodCategoryModel modelToDelete = GetDeletedById(id);

    //            if (modelToDelete != null)
    //            {

    //                FoodCategory entityToDelete = _mapper.Map<FoodCategory>(modelToDelete);


    //                var existingFoodCategory = _repository.GetById(modelToDelete.Id);


    //                if (existingFoodCategory == null)
    //                {
    //                    _repository.Attach(entityToDelete);
    //                    existingFoodCategory = entityToDelete; 
    //                }
    //                else
    //                {
    //                    _mapper.Map(modelToDelete, existingFoodCategory);
    //                }
    //                _repository.Remove(existingFoodCategory);
    //            }
    //            else
    //            {
    //                throw new Exception($"FoodCategory with ID {id} not found.");
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception($"Error: {ex.Message}");
    //        }
    //    }
    //    public void Update(FoodCategoryModel model)
    //    {
    //        try
    //        {
    //            FoodCategory entity = _mapper.Map<FoodCategory>(model);
    //            var existingFoodCategory = _repository.GetById(model.Id);

    //            if (existingFoodCategory == null)
    //            {
    //                _repository.Attach(entity);
    //                existingFoodCategory = entity; 
    //            }
    //            else
    //            {
    //                _mapper.Map(model, existingFoodCategory);
    //            }

    //            _repository.Update(existingFoodCategory);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception($"Error: {ex.Message}");
    //        }
    //    }
    //    public void Remove(FoodCategoryModel model)
    //    {
    //        try
    //        {
    //            FoodCategory entity = _mapper.Map<FoodCategory>(model);
    //            var existingFoodCategory = _repository.GetById(model.Id);

    //            if (existingFoodCategory == null)
    //            {
    //                _repository.Attach(entity);
    //                existingFoodCategory = entity; 
    //            }
    //            else
    //            {
    //                _mapper.Map(model, existingFoodCategory);
    //            }

    //            _repository.Remove(existingFoodCategory);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception($"Error: {ex.Message}");
    //        }
    //    }

    //}
}
