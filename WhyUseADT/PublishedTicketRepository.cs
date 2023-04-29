using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WhyUseADT
{
    internal class PublishedTicketRepository
    {
        public void Publish(IEnumerable<Ticket> tickets)
        {
            //Something like issuing SQL queries... I'm not sure though.
            var queryBuilder = new QueryBuilder();

            foreach(var ticket in tickets)
            {
                if (!Ticket.Match(
                    ticket,
                    queryBuilder.PublishNormalTicket,
                    queryBuilder.PublishMemberTicket,
                    queryBuilder.PublishVIPTicket,
                    queryBuilder.PublishPairTicket))
                {
                    throw new Exception();
                }
            }

            queryBuilder.Execute();
        }

        private class QueryBuilder
        {

            public bool PublishNormalTicket(NormalTicket normalTicket)
            {
                return true;
            }

            public bool PublishMemberTicket(MemberTicket memberTicket)
            {
                return true;
            }
            public bool PublishVIPTicket(VIPTicket vipTicket)
            {
                return true;
            }
            public bool PublishPairTicket(PairTicket pairTicket)
            {
                return true;
            }

            public void Execute()
            {

            }
        }
    }
}
