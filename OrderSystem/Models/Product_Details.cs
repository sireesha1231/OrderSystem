using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    [Table("Product_Details")]
    public class Product_Details
    {
        [Key]
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public decimal Product_Price { get; set; }
        public int Category_ID { get; set; }
        public int Sub_Category_ID { get; set; }
        public string Product_Image { get; set; }
    }
}
