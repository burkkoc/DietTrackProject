using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.BLL.Models
{
    public class UserFoodModel
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public virtual Food Food { get; set; }

        public int UserInformationId { get; set; }
        public virtual UserInformation UserInformation { get; set; }

        public DataStatus DataStatus { get; set; }
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }

        public Portion Portion { get; set; }
        public int Piece { get; set; }
        public DateTime UCreated { get; set; }


    }
}
