using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyUseADT
{
    internal class PublishTicketPresenter
    {
        public void Present(IEnumerable<Ticket> tickets)
        {
            Console.WriteLine("********These tickets are published********");

            foreach (var ticket in tickets)
            {
                var text = Ticket.Match(ticket,
                    t => $"NormalTicket: buyer={t.Name}, price={t.Price}yen",
                    t => $"MemberTicket: No={t.MemberNo}, price={t.Price}(Discounted)",
                    t => $"VIPTicket: received={t.Name} (given it from {t.GaveName})",
                    t => $"PairTicket: buyer={t.Name1} and {t.Name2}");

                Console.WriteLine(text);
            }
        }
    }
}
