using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    [Table("Shopping_Cart")]
    public class Shopping_Cart
    {
        [Key]
        public int Shopping_ID { get; set; }
        public int User_ID { get; set; }
        public int Product_ID { get; set; }
        public int Product_Quantity { get; set; }
        public string Created_Date { get; set; }
    }
}
