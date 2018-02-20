using System;
using System.Linq;
using EFCoreTutorialGit;
using InvoicingRepository;

namespace InvoicingService
{
    public class MailService : IMailService
    {
        private static InvoicingToolContext invoicingContext = new InvoicingToolContext();
        UnitOfWork uow = new UnitOfWork(invoicingContext);
        public Mail GetMailByScheduleId(int id)
        {
            return uow.MailRepository.GetAll()
                .Where(a => a.InvoiceSchedId == id)
                .FirstOrDefault();         
        }
    }
}
