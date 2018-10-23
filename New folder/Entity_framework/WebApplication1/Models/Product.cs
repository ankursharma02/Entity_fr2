using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
   [Table("tblProducts")]
    public class Product
    {
        [Key]
        public int productid { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }

        public Category Category { get; set; }
    }
}