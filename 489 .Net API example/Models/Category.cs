using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _489_.Net_API_example.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


    }
}
