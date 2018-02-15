using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorialGit
{
    public class InvoiceSchedule
    { 
        public int InvoiceSchedId { get; set; }
        public string ScheduleName { get; set; }
        public string ReferenceNo { get; set; }
        public string ScheduleType { get; set; }
        public DateTime SchedStartDate { get; set; }
        public DateTime SchedEndDate { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
