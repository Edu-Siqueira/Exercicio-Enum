using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enums;
using System;

namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter Client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new(name, email, birthDate);

            Console.WriteLine("Enter Order data: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new(client, DateTime.Now, status);

            Console.Write("How many items? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"\nEnter #{i} item data: ");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem item = new(quantity, price, product);

                order.AddItem(item);
            }

            Console.WriteLine(order);
        }
    }
}