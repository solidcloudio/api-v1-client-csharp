﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Info.Blockchain.API
{
    /// <summary>
    /// The class `APIException` represents a failed call to the Blockchain API. Whenever
    /// the server is unable to process a request (usually due to parameter validation errors),
    /// an instance of this class is thrown.
    /// </summary>
    public class APIException : Exception
    {
        public APIException(String message)
            : base(message)
        {
        }
    }
}
