using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

// A product item and an item in a shopping cart.

namespace ShoppingCart.Models
{
    public class Item
    {
        public String Code { get; set; }
        public String Description { get; set; }
        [Display(Name="Price (€)")]
        public double Price { get; set; }
    }

    public class CartItem : Item
    {
        public int Quantity { get; set; }
    }
}