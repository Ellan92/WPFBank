using System;

namespace WPFBank
{
    public interface IAccount
    {
        public int Funds { get; set; }
    }

    public class SavingsAccount : IAccount
    {
        public int Funds { get; set; }

        public SavingsAccount(int funds)
        {
            Random random = new();

            funds = random.Next(1, 1001);
        }
    }

    public class SalaryAccount : IAccount
    {
        public int Funds { get; set; }
    }
}
