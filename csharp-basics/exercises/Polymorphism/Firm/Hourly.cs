namespace Firm
{
    public class Hourly : Employee
    {
        private int _hoursWorked;
        
        public Hourly(string eName, string eAddress, string ePhone, string socSecNumber, double rate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _hoursWorked = 0;
        }
        
        public void AddHours(int moreHours)
        {
            _hoursWorked += moreHours;
        }
        
        public override double Pay() 
        {
            var payment = payRate * _hoursWorked;
            _hoursWorked = 0;
            return payment;
        }
        
        public override string ToString() 
        {
            var result = base.ToString();
            result += "\nCurrent hours: " + _hoursWorked;
            return result;
        }
    }
}