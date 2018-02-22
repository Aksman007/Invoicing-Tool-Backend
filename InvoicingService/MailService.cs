using System;
using System.Linq;
using EFCoreTutorialGit;
using InvoicingRepository;

namespace InvoicingService
{
    public class MailService : IMailService
    {
        UnitOfWork uow;

        public MailService(InvoicingToolContext invoicingContext)
        {
            uow = new UnitOfWork(invoicingContext);
        }

        public MailService()
        {
            uow = new UnitOfWork(new InvoicingToolContext());
        }

        public Mail GetMailByScheduleId(int id)
        {
            return uow.MailRepository.GetAll()
                .Where(a => a.InvoiceSchedId == id)
                .FirstOrDefault();         
        }
    }
}
