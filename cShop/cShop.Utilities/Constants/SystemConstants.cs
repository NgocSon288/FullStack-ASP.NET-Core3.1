using System;
using System.Collections.Generic;
using System.Text;

namespace cShop.Utilities.Constants
{
    public static class SystemConstants
    {
        public static class AppSettings
        {
            public static readonly string MailSettings = "MailSettings";
            public static readonly string BaseAddressServer = "BaseAddressServer";
            public static readonly string BaseAddressWeb = "BaseAddressWeb";
            public static readonly string Token = "Token";
            public static readonly string Id = "Id";
            public static readonly string PaginationSetting = "PaginationSetting";
        }

        public static class DatabaseConstants
        {
            public static readonly string cShopConnectionString = "cShopConnectionString";
        }

        public static class Host
        {
            public static readonly string CallbackComfirmCreateAccount = "CallbackComfirmCreateAccount";
        }
    }
}
