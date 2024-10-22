using EFDiyet2.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet2.DAL.Repository.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DataStatus DataStatus { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }/*= DateTime.MinValue;*/
        public DateTime? Deleted { get; set; }/*= DateTime.MinValue;*/
        public DateTime UCreated { get; set; }
    }
}
