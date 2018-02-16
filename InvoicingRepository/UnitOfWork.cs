using EFCoreTutorialGit;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoicingRepository
{
    public class UnitOfWork
    {
        public readonly InvoicingToolContext _invoicingContext;
        private IGenericRepository<Invoice> _invoiceRepository;
        private IGenericRepository<InvoiceSchedule> _invoiceScheduleRepository;
        private IGenericRepository<Mail> _mailRepository;

        public UnitOfWork(InvoicingToolContext invoicingContext)
        {
            _invoicingContext = invoicingContext;
        }

        public IGenericRepository<Invoice> InvoiceRepository
        {
            get
            {
                return _invoiceRepository = _invoiceRepository ?? new GenericRepository<Invoice>(_invoicingContext);
            }
        }

        public IGenericRepository<InvoiceSchedule> InvoiceScheduleRepository
        {
            get
            {
                return _invoiceScheduleRepository = _invoiceScheduleRepository ?? new GenericRepository<InvoiceSchedule>(_invoicingContext);
            }
        }

        public IGenericRepository<Mail> MailRepository
        {
            get
            {
                return _mailRepository = _mailRepository ?? new GenericRepository<Mail>(_invoicingContext);
            }
        }
    }
}
