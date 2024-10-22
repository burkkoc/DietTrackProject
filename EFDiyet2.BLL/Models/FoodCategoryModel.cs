using EFDiyet2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.BLL.Models
{
    public class FoodCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
