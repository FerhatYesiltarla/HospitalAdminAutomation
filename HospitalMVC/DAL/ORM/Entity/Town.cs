using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ORM.Entity
{
    public class Town : BaseEntity
    {
        [ForeignKey("City")]
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
