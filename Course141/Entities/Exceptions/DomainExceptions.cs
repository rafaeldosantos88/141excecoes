using System;
using System.Collections.Generic;
using System.Text;

namespace Course141.Entities.Exceptions
{
    class DomainExceptions : ApplicationException   //É uma execeção do dominio do nossso sistema.É um termo técnico para referenciar um negocio do nosso sistema.
    {                                              //É uma subsclasse de AplicationException
        public DomainExceptions(string message) : base(message)
        {//Construtor recebendo string message.Simplesmente esse construtor vai passar mensagem para AplicationExceptions
        }
    }
}
