using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DadosDoPedido.Entities;
using DadosDoPedido.Entities.Enums;

namespace DadosDoPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Clien data:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Email:");
            string email = Console.ReadLine();
            Console.Write("Birth data(DD/MM/YYYY/AAAA):");
            DateTime birhDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Data:");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>  (Console.ReadLine());

            Client client = new Client(nome, email, birhDate);
            Order order = new Order(DateTime.Now, status, nome);

            Console.WriteLine("How many items to this order?");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Enter #{i} item data");
                Console.Write("Product Name");
                string name = Console.ReadLine();
                Console.Write("Product price:");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(name, price);

                Console.Write("Quantity:");
                int quant = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, name);

                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("Order Sumary:");
            Console.WriteLine("Order:");

           

        }
    }
}
