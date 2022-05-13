using System;
using System.Globalization;
using _37_Exercicio_Interfaces_SolucaoSemInterface.Entities;
using _37_Exercicio_Interfaces_SolucaoSemInterface.Services;

namespace _37_Exercicio_Interfaces_SolucaoSemInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Puckup (dd/MM/yyyy): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Price Per Hour: ");
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Price Per Day: ");
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(priceHour, priceDay);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE");
            Console.Write(carRental.Invoice);
        }
    }
}
