namespace BankTask
{
    using System;

    public class MortageAccount : Account, IDeposit
    {
        private const int MinimumPeriodIndividual = 6;
        private const int MinimumPeriodCompany = 12;
        private const decimal CompanyMinInterest = 0.5M;

        public MortageAccount(string clientName, ClientType clientType, decimal balance, decimal interestRate) :
            base(clientName, clientType, balance, interestRate)
        {
        }

        public override decimal CalcualteIneterst(int period)
        {
            if (this.Client == ClientType.Individual)
            {
                return period > MortageAccount.MinimumPeriodIndividual ? (this.IneterestRate * this.Balance) * period : 0;
            }

            return period > MortageAccount.MinimumPeriodCompany ? (this.IneterestRate * this.Balance) * period : (MortageAccount.CompanyMinInterest * this.Balance) * period;
        }
    }
}
