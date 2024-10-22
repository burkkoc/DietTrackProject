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
    public class UserInformationManager : Manager<UserInformationModel, UserInformation>
    {
        public UserInformationManager()
        {
            _repository = new UserInformationRepository(new EFDiyet2DbContext());
        }
    }
    
}//public UserInformationManager(IRepository<UserInformation> repository, IMapper mapper) : base(repository, mapper)
        //{
        //}
