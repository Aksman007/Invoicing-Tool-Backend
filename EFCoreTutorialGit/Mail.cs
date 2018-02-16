using System;
using System.Collections.Generic;

namespace EFCoreTutorialGit
{
    public class Mail
    {
        public int MailId { get; set; }
        public string MailSubject { get; set; }
        public string MailTo { get; set; }
        public string MailBody { get; set; }
        public bool? IsHTML { get; set; }
        public bool? IsSent { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
