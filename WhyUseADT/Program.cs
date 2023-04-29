using WhyUseADT;

var repository = new PublishedTicketRepository();
var presenter = new PublishTicketPresenter();
var usecase = new PublishTicketInteractor(presenter, repository);

var tickets = new List<Ticket>()
{
    new NormalTicket("Jonathan"),
    new MemberTicket(4),
    new VIPTicket("Pucchi", "DIO"),
    new PairTicket("Jolene", "Jotaro")
};

usecase.Handle(tickets);