using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ORM.Entity
{
    public class User : BaseEntity
    {
        [StringLength(6)]
        public string Password { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MaxLength(1)]
        public string Role { get; set; }

        [MaxLength(30)]
        public string Lastname { get; set; }
    }
}
