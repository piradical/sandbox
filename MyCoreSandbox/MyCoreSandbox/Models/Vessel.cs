using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreSandbox.Models
{
    [Table("Vessel")]
    public class Vessel
    {
        [Key]
        public int VesselID { get; set; }

        public string Name { get; set; }

        public string CreatedBy { get; set; } // CreatedBy (length: 100)

        public System.DateTime CreatedOn { get; set; } // CreatedOn

        [StringLength(100)]
        public string UpdatedBy { get; set; } // UpdatedBy (length: 100)

        public System.DateTime UpdatedOn { get; set; } // UpdatedOn

        [StringLength(500)]
        public string Description { get; set; } // Description (length: 500)
    }
}
