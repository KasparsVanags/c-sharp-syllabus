namespace Firm
{
    public abstract class StaffMember
    {
        private string _name;
        private string _address;
        private string _phone;
        
        protected StaffMember(string eName, string eAddress, string ePhone) 
        {
            _name = eName;
            _address = eAddress;
            _phone = ePhone;
        }
        
        public override string ToString() 
        {
            var result = "Name: " + _name + "\n";
            result += "Address: " + _address + "\n";
            result += "Phone: " + _phone;
            return result;
        }
        
        public abstract double Pay();
    }
}