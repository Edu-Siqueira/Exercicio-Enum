using ExercicioEnum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioEnum.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        private List<OrderItem> lista = new();

        public Order()
        {
        }

        public Order(Client client, DateTime moment, OrderStatus status)
        {
            Client = client;
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            lista.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            lista.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach (OrderItem item in lista)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");

            foreach (OrderItem item in lista)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
