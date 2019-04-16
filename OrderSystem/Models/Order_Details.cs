using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    [Table("Order_Details")]
    public class Order_Details
    {
        [Key]
        public int Order_ID { get; set; }
        public int Shopping_ID { get; set; }
        public int User_ID { get; set; }
        public string Time_Date { get; set; }
        public int Payment_ID { get; set; }
        public string Shipping_Address { get; set; }
        public string Billing_Address { get; set; }
        public decimal Product_Price { get; set; }
        public decimal Delivery_Cost { get; set; }
        public string Coupon_Code { get; set; }
        public decimal Final_Price { get; set; }
        public string Created_Date { get; set; }
        public int Invoice_ID { get; set; }

    }
}
