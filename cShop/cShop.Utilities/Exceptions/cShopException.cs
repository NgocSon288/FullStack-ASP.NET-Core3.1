using System;
using System.Collections.Generic;
using System.Text;

namespace cShop.Utilities.Exceptions
{
    public class cShopException : Exception
    {
        public cShopException()
        {
        }

        public cShopException(string message)
            : base(message)
        {
        }

        public cShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}