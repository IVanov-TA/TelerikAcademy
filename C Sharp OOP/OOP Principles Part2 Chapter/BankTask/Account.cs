namespace BankTask
{
    using System;

    public abstract class Account : IDeposit
    {
        private decimal accInterest;
        private decimal accBalance;
        private string accClientName;

        public Account(string clientName, ClientType client, decimal balance, decimal interestRate)
        {
            this.ClientName = clientName;
            this.Client = client;
            this.Balance = balance;
            this.IneterestRate = interestRate;
        }

        public string ClientName
        {
            get
            {
                return this.accClientName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name");
                }

                this.accClientName = value;
            }
        }

        public ClientType Client { get; private set; }

        public decimal Balance
        {
            get
            {
                return this.accBalance;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid balance");
                }

                this.accBalance = value;
            }
        }

        public decimal IneterestRate
        {
            get
            {
                return this.accInterest;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The ineterest must be positive number > 0");
                }

                this.accInterest = (value / 100) / 12;
            }
        }

        public abstract decimal CalcualteIneterst(int period);

        public void DepositMoney(decimal amount)
        {
            this.accBalance += amount;
            Console.WriteLine("You balance after depositing: {0}", this.Balance);
        }
    }
}
