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
    public class FoodRepository : Repository<Food>
    {
       
        public FoodRepository(EFDiyet2DbContext db) : base(db)
        {
        }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
