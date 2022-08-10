namespace Firm
{
    public class Volunteer: StaffMember
    {
        public Volunteer(string eName, string eAddress, string ePhone) : base(eName, eAddress, ePhone)
        {
        }
        
        public override double Pay()
        {
            return 0.0;
        }
    }
}