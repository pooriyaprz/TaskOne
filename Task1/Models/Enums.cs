using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class Enums
    {
        public enum PropertyLocation
        {
            [Display(Name = "شمالی")]
            North,
            [Display(Name = "جنوبی")]
            South
        }
    }
}
