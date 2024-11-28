using System.Text;
using Excecoes_Ex_01.Entities.Exceptions;

namespace Excecoes_Ex_01.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkin >= checkout)
            {
                throw new DomainException("Checkin date must be before checkout date.");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            return Checkout.Day - Checkin.Day;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now ||  checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates.");
            }
            if (checkin >= checkout)
            {
                throw new DomainException("Checkin date must be before checkout date.");
            }

            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("");
            sb.AppendLine("RESERVATION DATA:");
            sb.AppendLine($"Room: {RoomNumber}");
            sb.AppendLine($"{Checkin:dd/MM/yyyy} - {Checkout:dd/MM/yyyy}");
            sb.AppendLine($"Duration: {Duration()} nights");
            return sb.ToString();
        }
    }
}
