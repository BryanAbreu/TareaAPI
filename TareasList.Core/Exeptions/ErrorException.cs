using System;
using System.Collections.Generic;
using System.Text;

namespace TareasList.Core.Exeptions
{
    public class ErrorException : Exception
    {
        public string ErrorMessage { get; set; }
        public int StatusCode { get; set; }


        public ErrorException(string message, int statusCode) : base(message)
        {
            ErrorMessage = message;
            StatusCode = statusCode;
        }

    }
}
