namespace BankTask
{
    using System;

    public class DepositAccount : Account, IDeposit, IWithDraw
    {
        private const decimal MinimumSumRequired = 1000;

        public DepositAccount(string ownerName, ClientType client, decimal balance, decimal interestRate)
            : base(ownerName, client, balance, interestRate)
        {
        }

        public override decimal CalcualteIneterst(int period)
        {
            if (this.Balance == DepositAccount.MinimumSumRequired)
            {
                return 0;
            }
            else
            {
                return (this.IneterestRate * this.Balance) * period;
            }
        }

        #region IWithDraw Members

        public void WithDrawMoney(decimal sum)
        {
            if (sum > this.Balance)
            {
                Console.WriteLine("Not enough money");
            }
            else
            {
                this.Balance -= sum;
                Console.WriteLine("You balance after withdraw is: {0}", this.Balance);
            }
        }

        #endregion
    }
}
