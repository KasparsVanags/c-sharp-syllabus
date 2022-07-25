namespace Firm
{
    public class Executive : Employee
    {
        private double _bonus;
        
        //-----------------------------------------------------------------
        // Sets up an executive with the specified information.
        //-----------------------------------------------------------------
        public Executive(string eName, string eAddress, string ePhone, string socSecNumber, double rate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _bonus = 0; // bonus has yet to be awarded
        }
        //-----------------------------------------------------------------
        // Awards the specified bonus to this executive.
        //-----------------------------------------------------------------
        public void AwardBonus(double execBonus) 
        {
            _bonus = execBonus;
        }

        //-----------------------------------------------------------------
        // Computes and returns the pay for an executive, which is the
        // regular employee payment plus a one-time bonus.
        //-----------------------------------------------------------------
        public override double Pay() 
        {
            var payment = base.Pay() + _bonus;
            _bonus = 0;
            return payment;
        }
    }
}