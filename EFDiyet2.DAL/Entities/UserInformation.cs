using EFDiyet2.DAL.Enums;
using EFDiyet2.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.DAL.Entities
{
    public class UserInformation : BaseEntity
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public Gender Gender { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserFood> UserFoods { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
