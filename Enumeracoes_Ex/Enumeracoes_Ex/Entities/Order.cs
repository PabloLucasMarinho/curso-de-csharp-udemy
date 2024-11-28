using System.Text;
using System.Globalization;
using Enumeracoes_Ex.Entities.Enums;

namespace Enumeracoes_Ex.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = [];

        public Order() { }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem Item in Items)
            {
                total += Item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder str = new();
            str.AppendLine("");
            str.AppendLine("ORDER SUMMARY:");
            str.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            str.AppendLine($"Order status: {Status}");
            str.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            str.AppendLine("Order items:");
            foreach (OrderItem Item in Items)
            {
                str.AppendLine(
                    $"{Item.Product.Name}, " +
                    $"${Item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                    $"Quantity: {Item.Quantity}, " +
                    $"Subtotal: ${Item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}"
                );
            }
            str.AppendLine($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return str.ToString();
        }
    }
}
