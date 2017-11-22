using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.ORM.Entity
{
    public class PatientHistory : BaseEntity
    {
        [Column(TypeName = "datetime2")]
        public DateTime? HistoryDate { get; set; }

        public string Explanation { get; set; }

        [MaxLength(200)]
        public string DrugUsed { get; set; }

        [MaxLength(200)]
        public string Diseases { get; set; } //Geçirdiği hastalıklar

        [MaxLength(200)]
        public string Surgeries { get; set; } //Geçirdiği ameliyatlar

        [MaxLength(200)]
        public string Allergies { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
