﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Core_Practice.Entities
{
    [Table("Mycategorytable")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
