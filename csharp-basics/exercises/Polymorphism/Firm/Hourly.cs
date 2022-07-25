namespace Firm
{
    public class Hourly : Employee
    {
        private int _hoursWorked;
        //-----------------------------------------------------------------
        // Sets up this hourly employee using the specified information.
        //-----------------------------------------------------------------
        public Hourly(string eName, string eAddress, string ePhone, string socSecNumber, double rate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _hoursWorked = 0;
        }

        //-----------------------------------------------------------------
        // Adds the specified number of hours to this employee's
        // accumulated hours.
        //-----------------------------------------------------------------
        public void AddHours(int moreHours)
        {
            _hoursWorked += moreHours;
        }

        //-----------------------------------------------------------------
        // Computes and returns the pay for this hourly employee.
        //-----------------------------------------------------------------
        public override double Pay() 

            var payment = payRate * _hoursWorked;
            _hoursWorked = 0;
            return payment;
        }

        //-----------------------------------------------------------------
        // Returns information about this hourly employee as a string.
        //-----------------------------------------------------------------
        public override string ToString() 
        {
            var result = base.ToString();
            result += "\nCurrent hours: " + _hoursWorked;
            return result;
        }
    }
}