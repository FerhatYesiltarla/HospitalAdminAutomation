using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ORM.Entity
{
    public class Policlinic : BaseEntity
    {
        [ForeignKey("Hospital")]
        public int HospitalId { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
