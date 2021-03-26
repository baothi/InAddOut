using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAddOut.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }
        public string Borrower { get; set; }
    }
}
