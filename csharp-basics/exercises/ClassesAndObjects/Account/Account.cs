namespace Account
{
    class Account
    {
        private double _money;
        private readonly string _name;

        public Account(string name, double money)
        {
            _name = name;
            _money = money;
        }

        public void Withdrawal(double amount)
        {
            _money -= amount;
        }

        public void Deposit(double amount)
        {
            _money += amount;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }
    }
}
