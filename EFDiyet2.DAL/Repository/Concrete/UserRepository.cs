using EFDiyet2.DAL.Context;
using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.DAL.Repository.Concrete
{
    public class UserRepository : Repository<User>
    {
     
        public UserRepository(EFDiyet2DbContext db) : base(db)
        {

        }
        
    }
}
