using System;
using System.Globalization;
using TratamentoDeErros.Entities;
using TratamentoDeErros.Entities.Exceptions;

namespace TratamentoDeErros
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Room number: ");
            int room = int.Parse(Console.ReadLine());
            Console.Write("Check-in date: ");
            DateTime check_in = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date: ");
            DateTime check_out = DateTime.Parse(Console.ReadLine());

           // tratamento de erros - jeito porco
           /* if (check_in <= check_out)
            {
                Console.WriteLine("Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(room, check_in, check_out);
                Console.WriteLine(reservation);
             Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Room number: ");
            room = int.Parse(Console.ReadLine());
            Console.Write("Check-in date: ");
            check_in = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Check-out date: ");
            check_out = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                DateTime now = DateTime.Now;
                if (check_in < now || check_out < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
                }
                else if (check_in <= check_out)
                {
                    Console.WriteLine("Check-out date must be after check-in date");

                }
                else
                {
                    reservation.UpdateDates(check_in, check_out);
                }
            }
            */
            Reservation reservation = new Reservation(room, check_in, check_out);
            Console.WriteLine(reservation);
            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Room number: ");
            room = int.Parse(Console.ReadLine());
            Console.Write("Check-in date: ");
            check_in = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Check-out date: ");
            check_out = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            reservation.UpdateDates(check_in, check_out);
            Console.WriteLine();
            Console.WriteLine("Update reservation: ");
            Console.WriteLine($"Reservation: {reservation}");

            }
            catch (DomainException err) // erros da regra de negócio
            {

                Console.WriteLine($"Error in reservation: {err.Message}");
            }
            catch (FormatException err) // erro de formato (string no lugar de double e assim vai)
            {
                Console.WriteLine($"Format error: {err.Message}");
            }
            catch(Exception err)
            {
                Console.WriteLine($"Erro inesperado: {err.Message}");
            }   
        }
    }
}
