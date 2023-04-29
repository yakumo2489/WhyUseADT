using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyUseADT
{
    public abstract class Ticket
    {
        public abstract int Price { get; }

        public static T Match<T>(
            Ticket ticket,
            Func<NormalTicket, T> normalCase,
            Func<MemberTicket, T> memberCase,
            Func<VIPTicket, T> vipCase,
            Func<PairTicket, T> pairCase)
        {
            if (ticket is NormalTicket normal)
            {
                return normalCase(normal);
            }

            if (ticket is MemberTicket member)
            {
                return memberCase(member);
            }

            if (ticket is VIPTicket vip)
            {
                return vipCase(vip);
            }

            if (ticket is PairTicket pair)
            {
                return pairCase(pair);
            }

            throw new ArgumentException("invalid type ticket");
        }
    }

    public class NormalTicket : Ticket
    {
        public NormalTicket(string name)
        {
            Name = name;
        }

        public override int Price => 2000;

        public string Name { get; }
    }

    public class MemberTicket : Ticket
    {
        public MemberTicket(int memberNo)
        {
            MemberNo = memberNo;
        }

        public override int Price => 1800;

        public int MemberNo { get; }
    }

    public class VIPTicket : Ticket
    {
        public VIPTicket(string name, string gaveName)
        {
            Name = name;
            GaveName = gaveName;
        }

        public string Name { get; }
        public string GaveName { get; }

        public override int Price => 0;
    }

    public class PairTicket : Ticket
    {
        public PairTicket(string name1, string name2)
        {
            Name1 = name1;
            Name2 = name2;
        }

        public override int Price => 3800;

        public string Name1 { get; }
        public string Name2 { get; }
    }
}
