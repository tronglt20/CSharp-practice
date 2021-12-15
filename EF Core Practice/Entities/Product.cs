using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Core_Practice.Entities
{
    [Table("MyProductTable")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        [Column("Ten san pham")]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        public int CateId { get; set; }

        [ForeignKey("CateId")]
        [Required]
        public virtual Category category { get; set; }

    }
}
