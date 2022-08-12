namespace Firm
{
    public class Employee : StaffMember
    {
        private string socialSecurityNumber;
        protected double payRate;
        
        public Employee(string eName, string eAddress, string ePhone,
            string socSecNumber, double rate) : base(eName, eAddress, ePhone)
        {
            socialSecurityNumber = socSecNumber;
            payRate = rate;
        }
        
         public override string ToString() 
        {
             var result = base.ToString();
             result += "\nSocial Security Number: " + socialSecurityNumber;
             return result;
         }
         
        public override double Pay()
        {
            return payRate;
        }
    }
}