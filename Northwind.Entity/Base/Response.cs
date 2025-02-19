﻿using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Base
{
    public class Response: IResponse
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public object Data { get; set; }

    }

    public class Response<T> : IResponse<T>   //neden kullandık ???
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }

    }
}
