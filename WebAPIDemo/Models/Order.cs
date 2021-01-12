using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    [Table("tblOrder")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }
        public string OrderDesc { set; get; }
        public int Quantity { get; set; }
        public Product product { get; set; }
    }
}