namespace Firm
{
    public class Volunteer: StaffMember
    {
        //-----------------------------------------------------------------
        // Sets up a volunteer using the specified information.
        //-----------------------------------------------------------------
        public Volunteer(string eName, string eAddress, string ePhone) : base(eName, eAddress, ePhone)
        {
        }

        //-----------------------------------------------------------------
        // Returns a zero pay value for this volunteer.
        //-----------------------------------------------------------------
        public override double Pay()
        {
            return 0.0;
        }
    }
}