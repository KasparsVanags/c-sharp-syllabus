using System;

namespace Firm
{
    public class Employee : StaffMember
    {
        private string socialSecurityNumber;

        protected double payRate;

        //-----------------------------------------------------------------
        // Sets up an employee with the specified information.
        //-----------------------------------------------------------------
        public Employee(string eName, string eAddress, string ePhone,
            string socSecNumber, double rate) : base(eName, eAddress, ePhone)
        {
            socialSecurityNumber = socSecNumber;
            payRate = rate;
        }

        //-----------------------------------------------------------------
        // Returns information about an employee as a string.
        //-----------------------------------------------------------------
         public override string ToString() 
        {
             var result = base.ToString();
             result += "\nSocial Security Number: " + socialSecurityNumber;
             return result;
         }

        //-----------------------------------------------------------------
        // Returns the pay rate for this employee.
        //-----------------------------------------------------------------
        public override double Pay()
        {
            return payRate;
        }
    }
}