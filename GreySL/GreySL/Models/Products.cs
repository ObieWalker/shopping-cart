using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreySL.Models
{
    public class Products
    {
        public int ID { get; set; }

        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        public string Description { get; set; }
        [Display(Name = "Price (₦)")]
        public decimal price { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Product Image ")]
        public string ImageUrl { get; set; }

    }
}