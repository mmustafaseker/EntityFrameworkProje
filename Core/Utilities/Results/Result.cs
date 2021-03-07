using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // result'ın tek parametreli ctor'una : şunuda gönder
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            //overloading
            Success = success;
        }
        // ctor da set edilebilirler
        public bool Success { get; }

        public string Message { get; }

    }
}
