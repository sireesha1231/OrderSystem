using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    public class Sub_Category_Details
    {
        [Key]
        public int Sub_Category_ID { get; set; }
        public string Sub_Category_Name { get; set; }
        public int Category_ID { get; set; }
    }
}
