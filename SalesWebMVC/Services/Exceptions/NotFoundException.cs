using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        //O contrutor irá repassar a mensagem para a classe "base"
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
