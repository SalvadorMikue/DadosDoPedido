using System;
using DadosDoPedido.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DadosDoPedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public string Client { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, string client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem( OrderItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            items.Add(item);
        }
        public double Total()
        {
            double sum = 0;
            foreach ( OrderItem item  in items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment:" + Moment.ToString("dd/MM/aaaa HH:mm:ss"));
            sb.AppendLine("Order status:" + Status);
            sb.AppendLine("Client:" + Client);
            sb.AppendLine("Order items:");

            foreach(OrderItem item in items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço total: $ " + Total().ToString());
            return sb.ToString();
        }
    }
}
