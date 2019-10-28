using System;
using Course141.Entities;
using Course141.Entities.Exceptions;

namespace Course141
{
    class Program
    {
        static void Main(string[] args)
        {

            try {
                Console.WriteLine("Room number : ");                      //Número do quarto
                int number = int.Parse(Console.ReadLine());
                Console.Write("check-in date (dd/MM/yyyy) : ");           //Data de entrada
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out date(dd / MM / yyyy) : ");      //Data de Saída
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation : " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter  data to Update the reservation : ");                   //Entre com os dados para atualizar a reserva
                Console.Write("check-in date (dd/MM/yyyy) : ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("check-out date(dd / MM / yyyy) : ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reservation : " + reservation);
            }
            catch (DomainExceptions e) //No caso se der um erro na exceção vai capiturar Domain Exception
            {
                Console.WriteLine("Error in reservation: " + e.Message);

            }
            catch(FormatException e)
            {
                Console.WriteLine("Format Error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro unexpected: " + e.Message);   //Erro inesperado
            }

            }
    }

            

             

        }
    
