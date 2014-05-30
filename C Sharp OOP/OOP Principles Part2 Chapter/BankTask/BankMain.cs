namespace BankTask
{
    using System;
    using System.Collections.Generic;

    public class BankMain
    {
        public static void Main()
        {
            IEnumerable<Account> bankAccounts = new List<Account>()
            {
                new DepositAccount("Mirko", ClientType.Individual, 1001, 2),
                new LoanAccount("HiTechCrunch", ClientType.Company, 50000, 2),
                new MortageAccount("Pesho-lihvarqt", ClientType.Individual, 4000, 3)
            };

            foreach (var account in bankAccounts)
            {
                Console.WriteLine("{0} -> {1:0.00}", account.GetType().Name, account.CalcualteIneterst(4));
            }
        }
    }
}
