using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Feitosa.DesignPatterns.Investor
{
    public interface IInvestorType
    {
        double Invest(double amount);
    }

    public class Conservator : IInvestorType
    {
        public double Invest(double amount)
        {
            return amount * 0.8d;
        }
    }
    public class Moderate : IInvestorType
    {
        public double Invest(double amount)
        {
            bool lucky = new Random().Next(101) > 50;
            return lucky ? amount * 2.5d: amount * 0.7d;
        }
    }
    public class Bold : IInvestorType
    {
        public double Invest(double amount)
        {
            int random = new Random().Next(101);
            return random <= 20 ? amount * 5d : random <= 50 ? amount * 3d : amount * 0.006d;
        }
    }
    public class InvestmentMaker
    {
        public InvestmentMaker(double amount, IInvestorType type) 
        {
            type.Invest(amount);
        }
    }
}
