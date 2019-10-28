using System;
using Course141.Entities;

namespace Course141
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Room number : ");                      //Número do quarto
            int number = int.Parse(Console.ReadLine());
            Console.Write("check-in date (dd/MM/yyyy) : ");           //Data de entrada
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("check-out date(dd / MM / yyyy) : " );      //Data de Saída
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn)
            {
                Console.WriteLine("Erro in  reservation: check-out date must be after check-in"); //Erro de reserva a data de checkOute deve ser depois da data de CheckIn
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation : " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter  data to Update the reservation : ");                   //Entre com os dados para atualizar a reserva
                Console.Write("check-in date (dd/MM/yyyy) : ");           
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out date(dd / MM / yyyy) : ");      
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);
                if(error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
             
                    Console.WriteLine("Reservation : " + reservation);
                }

            }
            

             

        }
    }
}
