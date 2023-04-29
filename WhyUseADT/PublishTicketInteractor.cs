using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyUseADT
{
    internal class PublishTicketInteractor
    {
        private readonly PublishTicketPresenter presenter;
        private readonly PublishedTicketRepository repository;

        public PublishTicketInteractor(PublishTicketPresenter presenter, PublishedTicketRepository repository)
        {
            this.presenter = presenter;
            this.repository = repository;
        }

        public void Handle(IEnumerable<Ticket> tickets)
        {
            repository.Publish(tickets);

            presenter.Present(tickets);
        }
    }
}
