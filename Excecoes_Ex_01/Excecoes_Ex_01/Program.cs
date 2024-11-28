using Excecoes_Ex_01.Entities;
using Excecoes_Ex_01.Entities.Exceptions;

try
{
    Console.WriteLine("Enter reservation data:");
    Console.WriteLine("");
    Console.Write("Room number: ");
    int roomNumber = int.Parse(Console.ReadLine());
    Console.Write("Checkin date (DD/MM/YYYY): ");
    DateTime checkin = DateTime.Parse(Console.ReadLine());
    Console.Write("Checkout date (DD/MM/YYYY): ");
    DateTime checkout = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new(roomNumber, checkin, checkout);
    Console.WriteLine(reservation);

    Console.WriteLine("Enter data to update the reservation:");
    Console.Write("Checkin date (DD/MM/YYYY): ");
    checkin = DateTime.Parse(Console.ReadLine());
    Console.Write("Checkout date (DD/MM/YYYY): ");
    checkout = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkin, checkout);
    Console.WriteLine(reservation);
}
catch (DomainException e)
{
    Console.WriteLine($"Error in reservation: {e.Message}");
}
catch (FormatException)
{
    Console.WriteLine("Error in reservation: Invalid input!");
}
catch (Exception e)
{
    Console.WriteLine($"Unexpected error: {e.Message}");
}