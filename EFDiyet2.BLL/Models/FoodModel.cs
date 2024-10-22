using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.BLL.Models
{
    public class FoodModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Calorie { get; set; }
        public float Fat { get; set; }
        public float Protein { get; set; }
        public float Carbohydrate { get; set; }
        public float Fiber { get; set; }
        public int FoodCategoryId { get; set; }
        public byte[] Picture { get; set; }
        public FoodCategory FoodCategory { get; set; }
        public ICollection<UserFood> UserFoods { get; set; }
        public DataStatus DataStatus { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
