using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Migration.Entities
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int CardId { get; set; }

        [ForeignKey("CardId")]
        public Card card { get; set; }
    }
}
