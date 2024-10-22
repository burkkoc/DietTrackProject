using AutoMapper;
using EFDiyet2.BLL.Manager.Abstract;
using EFDiyet2.BLL.Models;
using EFDiyet2.DAL.Context;
using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Repository.Abstract;
using EFDiyet2.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.BLL.Manager.Concrete
{
    public class UserFoodManager :Manager<UserFoodModel,UserFood>
    {
        public UserFoodManager()
        {
            _repository = new UserFoodRepository(new EFDiyet2DbContext());
        }
    }
    
}//public UserFoodManager(IRepository<UserFood> repository, IMapper mapper) : base(repository, mapper)
        //{
        //}
 