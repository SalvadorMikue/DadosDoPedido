using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosDoPedido.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, string product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double  SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product + " ,$ " + Price + " ,Quantity:" + Quantity + ",Subtotal: $" +
                SubTotal().ToString();
        }
    }
}
