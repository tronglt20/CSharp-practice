using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Migration.Entities
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
