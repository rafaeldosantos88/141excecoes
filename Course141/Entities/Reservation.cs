using System;
using System.Collections.Generic;
using System.Text;
using Course141.Entities.Exceptions;

namespace Course141.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }                         //Número do quarto
        public DateTime CheckIn { get; set; }                      //Entrada
        public DateTime CheckOut { get; set; }                    //Saída

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainExceptions("Erro in  reservation: check-out date must be after check-in");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration() //Metodo para Calcular duração de reservas em diarias.TimeSpam que é a duração o qual vou chaamr ele de "duration"
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn); //Pega a diferença entre um instante e outro aonde vamo ter uma duração(duration) que é do tipo TimeSpam
            return (int)duration.TotalDays;                 //Fizemos um Casting por ser do tipo double o "TotalDays"

        }
        public void UpdateDates(DateTime checkIn,DateTime checkOut)
        {
            DateTime now = DateTime.Now;         //Instante "atual" ou agora.Variavel chama now recebendo DateTime.Now
            if (checkIn < now || checkOut < now)  //Agora vou testar se o valor que digitei de checkIn(Entrada) for menor doque now(agora)ou valor checkOut for menor doque agora,Então essa data não pode ser alterada
            {
               throw new DomainExceptions("Erro Reservation ");//Vai dar erro na reserva,tem ser datas futuras.Comando throw serve para lança uma instancia de DomainExecption

            }
             if (checkOut <= checkIn)
            {
               throw new DomainExceptions( "Erro in  reservation: check-out date must be after check-in");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
   
        }
        public override string ToString()
        {
            return " Room "
                + RoomNumber                        //Concatenei com numero do quarto ou número da reserva
                + ", check-in: "                   //Entrada
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out : "
                + CheckOut.ToString("dd/MM/yyyy")
                + " , "
                + Duration()
                + " Nights";                   //Tantas Noites
        }
    }
}
