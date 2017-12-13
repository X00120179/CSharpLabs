using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    // A shopping cart
    public class Cart
    {
        private List<CartItem> items;

        public Cart()
        {
            items = new List<CartItem>();
        }

        // Add an item to the cart i.e. increase the qty of tha item in the cart
        // +
        public void AddItem(Item item)
        {
            // Code is unique
            var match = items.FirstOrDefault(i => i.Code.ToUpper(CultureInfo.CurrentCulture) == item.Code.ToUpper(CultureInfo.CurrentCulture));
            if(match == null)
            {
                items.Add(new CartItem() { Code = item.Code, Description = item.Description, Price = item.Price, Quantity = 1 });
            } else
            {
                match.Quantity++;
            }
        }

        // Calculate tota price of cart
        public double CalculateTotalPrice()
        {
            return items.Sum(item => item.Price * item.Quantity);
        }
    }
}