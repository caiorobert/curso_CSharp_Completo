using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime chechIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime chechOut = DateTime.Parse(Console.ReadLine());

            if (chechOut <= chechIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, chechIn, chechOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                chechIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                chechOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if(chechIn < now || chechOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
                }else if (chechOut <= chechIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    reservation.UpdateDates(chechIn, chechOut);
                    Console.WriteLine($"Reservation: {reservation}");
                }
            }
        }
    }
}
