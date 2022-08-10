namespace Firm
{
    public class Executive : Employee
    {
        private double _bonus;
        
        public Executive(string eName, string eAddress, string ePhone, string socSecNumber, double rate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _bonus = 0;
        }
        
        public void AwardBonus(double execBonus) 
        {
            _bonus = execBonus;
        }
        
        public override double Pay() 
        {
            var payment = base.Pay() + _bonus;
            _bonus = 0;
            return payment;
        }
    }
}