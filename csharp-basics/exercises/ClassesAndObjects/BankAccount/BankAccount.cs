using System.Globalization;

namespace BankAccount
{
    public class BankAccount
    {
        private readonly string _user;
        private readonly double _balance;
        public BankAccount(string user, double balance)
        {
            _user = user;
            _balance = balance;
        }

        private string FormattedBalance()
        {
            var usdFormat = new CultureInfo("en-US")
            {
                NumberFormat =
                {
                    CurrencyNegativePattern = 1
                }
            };
            
            return _balance.ToString("C", usdFormat);
        }

        public string ShowUserNameAndBalance()
        {
            return $"{_user}, {FormattedBalance()}";
        }
    }
}