using EFDiyet2.DAL.Enums;
using EFDiyet2.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.DAL.Entities
{
    public class UserFood : BaseEntity
    {
        public int FoodId { get; set; }
        public virtual Food Food { get; set; }
        public int UserInformationId { get; set; }
        public virtual UserInformation UserInformation { get; set; }
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }
        public Portion Portion { get; set; }
        public int Piece { get; set; }
    }
}
