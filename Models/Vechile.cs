using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codesampleprogram.Models
{
    public class Vechile
    {
        [Key]
        public int VehId { get; set; }
        public int VehSerialno { get; set; }
        public string VehName { get; set; }
        public int VehPrice { get; set; }
    }
}
