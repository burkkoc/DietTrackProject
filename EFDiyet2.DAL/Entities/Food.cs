using EFDiyet2.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.DAL.Entities
{
    public class Food : BaseEntity
    {
        public string Name { get; set; }
        public float Calorie { get; set; }
        public float Fat { get; set; }
        public float Protein { get; set; }
        public float Carbohydrate { get; set; }
        public float Fiber { get; set; }
        public int FoodCategoryId { get; set; }
        public byte[] Picture { get; set; }
       
        
        public virtual FoodCategory FoodCategory { get; set; }
        public virtual ICollection<UserFood> UserFoods { get; set; }
        public override string ToString()
        {
            return Name;
        }
        
    }
}
