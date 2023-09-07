﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class Result : IResult
    {
        public Result(string message, bool success) : this(success)
        {
            Message = message;  
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }

    }
}
