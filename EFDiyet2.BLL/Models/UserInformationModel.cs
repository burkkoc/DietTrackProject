using EFDiyet2.DAL.Entities;
using EFDiyet2.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.BLL.Models
{
    public class UserInformationModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public Gender Gender { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<UserFood> UserFoods { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
