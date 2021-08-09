using System.Collections.Generic;

namespace cShop.Utilities.Models
{
    public class MailContent
    {
        public MailContent(string to, string subject, string fileName, Dictionary<string, string> bodyKeyValue = null)
        {
            To = to;
            Subject = subject;
            BodyKeyValue = bodyKeyValue;
            this.fileName = fileName;
        }

        public string To { get; set; }

        public string Subject { get; set; }

        public Dictionary<string, string> BodyKeyValue { get; set; }

        public string fileName { get; set; }
    }
}