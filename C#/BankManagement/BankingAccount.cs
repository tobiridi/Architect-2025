using System.Security.Cryptography;

namespace BankManagement
{
    public class BankingAccount
    {
        public string Number { get; set; }

        public double Value { get; private set; }

        private double _CreditLine;

        public double CreditLine
        {
            get { return _CreditLine; }
            set { _CreditLine = value < 0 ? 0 : value; }
        }

        public Person Owner { get; set; }

        public BankingAccount()
        {
            
        }

        public void Withdrawal(double value)
        {

        }

        public void Deposit(double value)
        {

        }
    }
}
