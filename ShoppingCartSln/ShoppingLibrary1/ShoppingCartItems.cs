

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCartItem
    {
        public string Name;
        public double Price;
        public ShoppingCartItem(string name, double price)
        {
            Name = name;
            Price = _price;
        }
        public string _productName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public double _price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}

















