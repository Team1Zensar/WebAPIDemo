using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        public string ProductName { get; set; } 
        public int Price { set; get; }
    }
}