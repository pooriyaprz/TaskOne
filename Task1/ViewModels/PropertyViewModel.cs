using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1.Models;
using static Task1.Models.Enums;

namespace Task1.ViewModels
{
    public class PropertyViewModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public float Area { get; set; }
        public string Address { get; set; }
        public PropertyLocation PropertyLocation { get; set; }
        public string OwnerName { get; set; }
        public string OwnerFamily { get; set; }
        public int OwnerId { get; set; }
        public string FullName { get; set; }



    }
}
