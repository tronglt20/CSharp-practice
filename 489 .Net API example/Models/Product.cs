using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }

        public int CateId { get; set; }

        [ForeignKey("CateId")]
        public virtual Category Category{ get; set; }
    }
}
