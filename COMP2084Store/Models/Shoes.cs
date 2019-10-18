using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084Store.Models
{
    public class Shoes
    {
        [Key]

        public int ShoeId { get; set; }

        [ForeignKey("TypeId")]

        public int TypeId { get; set; }

        public String Size { get; set; }

        public int Price { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}
