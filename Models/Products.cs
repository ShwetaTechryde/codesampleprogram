using System.ComponentModel.DataAnnotations;

namespace codesampleprogram.Models
{
    public class Products
    {  
        [Key]
        public int Id { get; set; }
        public int Serialno { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
