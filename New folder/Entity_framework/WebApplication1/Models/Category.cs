using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    [Table("tblCategory")]
    public class Category
    {   [Key]
        public int Categoryid { set; get; }
        public string  CategoryName { set; get; }

    }
}