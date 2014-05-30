namespace BankTask
{
    using System;

    public class LoanAccount : Account, IDeposit
    {
        private const int MinimumIndividualPeriod = 3;
        private const int MinimumPeriodCompany = 2;

        public LoanAccount(string clientName, ClientType clientType, decimal balance, decimal interestRate) :
            base(clientName, clientType, balance, interestRate)
        {
        }

        public override decimal CalcualteIneterst(int period)
        {
            if (this.Client == ClientType.Individual)
            {
                return period > LoanAccount.MinimumIndividualPeriod ? (this.IneterestRate * this.Balance) * period : 0;
            }

            return period > LoanAccount.MinimumPeriodCompany ? (this.IneterestRate * this.Balance) * period : 0;
        }
    }
}
