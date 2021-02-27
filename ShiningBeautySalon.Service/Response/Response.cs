using System;
using System.Collections.Generic;
using System.Text;

namespace ShiningBeautySalon.Service.Response
{
    public class Response<T>
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }
    }
}
