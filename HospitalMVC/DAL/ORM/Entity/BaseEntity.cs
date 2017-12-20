using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.ORM.Entity
{
    public class BaseEntity
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }

        [MaxLength(100), Column(Order = 2)]
        public string Name { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? InsertDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DeleteDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
