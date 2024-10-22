using EFDiyet2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.BLL.Models
{
    public class MealModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserFood> userFoods { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
