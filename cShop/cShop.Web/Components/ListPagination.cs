using cShop.Utilities.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace cShop.AdminApp.Components
{
    public class ListPagination : ViewComponent
    {
        public class PaginationModel
        {
            public List<object> Data { get; set; }

            public Type Type { get; set; }

            public Dictionary<string, string> DisplayNameValuess { get; set; }

            public List<ModifiedButton> ModifiedButtons { get; set; }

            public List<GlobalButton> GlobalButtons { get; set; }
        }

        public class GlobalButton
        {
            public string Url { get; set; }

            public string Text { get; set; }

            public string Classes { get; set; }

            public string ControllerName { get; set; }

            public string ActionName { get; set; }
        }

        public class ModifiedButton
        {
            public string Url { get; set; }

            public string Text { get; set; }

            public string Classes { get; set; }

            public string ControllerName { get; set; }

            public string ActionName { get; set; }

            public string Id { get; set; }

            public Dictionary<string, UrlButton> RouteDatas { get; set; }
        }

        public class UrlButton
        {
            public string Value { get; set; }

            public string PropertyName { get; set; }
        }

        public IViewComponentResult Invoke(PaginationModel model)
        {
            return View("ListPagination", model);
        }
    }
}