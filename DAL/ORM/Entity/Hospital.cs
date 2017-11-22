using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.ORM.Entity
{
    public class Hospital : BaseEntity
    {
        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        [ForeignKey("Town")]
        public int TownId { get; set; }
        public virtual Town Town { get; set; }
    }
}
