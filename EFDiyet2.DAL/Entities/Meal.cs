using EFDiyet2.DAL.Enums;
using EFDiyet2.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.DAL.Entities
{
    public class Meal: BaseEntity
    { 
        public string Name { get; set; }
        public virtual ICollection<UserFood> userFoods { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
