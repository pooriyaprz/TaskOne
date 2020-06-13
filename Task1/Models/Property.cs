using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Task1.Models.Enums;

namespace Task1.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public float Area { get; set; }
        public string Address { get; set; }
        public PropertyLocation PropertyLocation { get; set; }
        [ForeignKey("OwnerId")]
        public int OwnerId { get; set; }

        public Owner Owner { get; set; }
    }
}
