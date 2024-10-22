using EFDiyet2.DAL.Context;
using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.DAL.Repository.Concrete
{
    public class UserFoodRepository : Repository<UserFood>
    {
        
        public UserFoodRepository(EFDiyet2DbContext db) : base(db)
        {
        }
        public override IQueryable<UserFood> GetAll()
        {
            return base.GetAll();
            
        }
    }
}
