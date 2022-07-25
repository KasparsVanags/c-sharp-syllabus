namespace Firm
{
    public abstract class StaffMember
    {
        private string name;
        private string address;
        private string phone;

        //-----------------------------------------------------------------
        // Sets up a staff member using the specified information.
        //-----------------------------------------------------------------
        protected StaffMember(string eName, string eAddress, string ePhone) 
        {
            name = eName;
            address = eAddress;
            phone = ePhone;
        }

        //-----------------------------------------------------------------
        // Returns a string including the basic employee information.
        //-----------------------------------------------------------------
        public override string ToString() 
        {
            var result = "Name: " + name + "\n";
            result += "Address: " + address + "\n";
            result += "Phone: " + phone;
            return result;
        }

        //-----------------------------------------------------------------
        // Derived classes must define the pay method for each type of
        // employee.
        //-----------------------------------------------------------------
        public abstract double Pay();
    }
}