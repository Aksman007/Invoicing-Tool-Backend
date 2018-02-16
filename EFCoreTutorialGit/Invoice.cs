using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreTutorialGit
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsAccured { get; set; }
        public float? Amount { get; set; }

        public int? InvoiceSchedId { get; set; }
        public InvoiceSchedule InvoiceSchedule { get; set; }
    }
}
