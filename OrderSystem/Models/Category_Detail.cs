using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    [Table("Category_Detail")]
    public class Category_Detail
    {
        [Key]
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
    }
}
