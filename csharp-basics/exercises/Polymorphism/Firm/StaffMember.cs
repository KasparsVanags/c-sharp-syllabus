namespace Firm
{
    public abstract class StaffMember
    {
        private string name;
        private string address;
        private string phone;
        
        protected StaffMember(string eName, string eAddress, string ePhone) 
        {
            name = eName;
            address = eAddress;
            phone = ePhone;
        }
        
        public override string ToString() 
        {
            var result = "Name: " + name + "\n";
            result += "Address: " + address + "\n";
            result += "Phone: " + phone;
            return result;
        }
        
        public abstract double Pay();
    }
}