using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        //O contrutor irá repassar a mensagem para a classe "base"
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
