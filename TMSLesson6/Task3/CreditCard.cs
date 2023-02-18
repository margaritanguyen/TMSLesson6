using System;

namespace TMSLesson6
{
    public class CreditCard
    {
        public string AccountNumber { get; set; }
        public double CurrentBalance { get; set; }

        public CreditCard(string accountNumberInit, double currentBalanceInit)
        {
            AccountNumber = accountNumberInit;
            CurrentBalance = currentBalanceInit;
        }

        public void Plus(double sum)
        {
            CurrentBalance += sum;
        }

        public void Minus(double sum)
        {
            CurrentBalance -= sum;
        }

        public void ShowCurrentState()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}; Текущий баланс: {CurrentBalance:F2}");
        }

    }
}
