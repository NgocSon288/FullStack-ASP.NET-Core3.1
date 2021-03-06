using System;
using System.Collections.Generic;
using System.Text;

namespace cShop.ViewModel.Common
{
    public class ApiResult<T>
    {
        public bool IsSuccessfully { get; set; }

        public string MessageError { get; set; }

        public T Data { get; set; }

        public ApiResult()
        {

        }

        public ApiResult(bool isSuccessfully, string message, T data)
        {
            IsSuccessfully = isSuccessfully;
            MessageError = message;
            Data = data;
        }

        public ApiResult(bool isSuccessfully, string message)
        {
            IsSuccessfully = isSuccessfully;
            MessageError = message;
            Data = default;
        }
    }
}
