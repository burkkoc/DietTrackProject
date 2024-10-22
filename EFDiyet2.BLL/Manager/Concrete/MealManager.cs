using EFDiyet2.DAL.Repository.Concrete;
using EFDiyet2.BLL.Manager.Abstract;
using EFDiyet2.BLL.Models;
using EFDiyet2.DAL.Context;
using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EFDiyet2.DAL.Repository.Abstract;

namespace EFDiyet2.BLL.Manager.Concrete
{
    public class MealManager : Manager<MealModel,Meal>
    {
        public MealManager()
        {
            _repository = new MealRepository(new EFDiyet2DbContext());
        }   
    }
    //public MealManager(IRepository<Meal> repository, IMapper mapper) : base(repository, mapper)
        //{
        //}
}
