using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ORM.Entity
{
    public class Appoinment : BaseEntity
    {
        [Column(TypeName = "datetime2")]
        public DateTime? Date { get; set; }

        public byte IsCome { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey("Policlinic")]
        public int PoliclinicId { get; set; }
        public virtual Policlinic Policlinic { get; set; }

        [ForeignKey("Staff")]
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
