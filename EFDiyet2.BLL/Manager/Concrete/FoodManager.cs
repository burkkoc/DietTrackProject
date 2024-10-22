
using EFDiyet2.BLL.Manager.Abstract;
using EFDiyet2.BLL.Models;
using EFDiyet2.DAL.Context;
using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Enums;
using EFDiyet2.DAL.Repository.Abstract;
using EFDiyet2.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.BLL.Manager.Concrete
{
    public class FoodManager : Manager<FoodModel,Food>
    {
        public FoodManager()
        {
            _repository = new FoodRepository(new EFDiyet2DbContext());

        }
    }
    //public FoodManager(IRepository<Food> repository, IMapper mapper) : base(repository, mapper)
    //{
    //}
    //public void Attach(FoodModel model)
    //{
    //    Food entity = _mapper.Map<Food>(model);
    //    _repository.Attach(entity);
    //}
    //public byte[] GetFoodPictureById(int foodId)
    //{
    //    FoodModel foodModel = GetById(foodId);

    //    if (foodModel != null)
    //    {
    //        return foodModel.Picture;
    //    }

    //    return null;
    //}

}

