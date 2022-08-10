namespace Firm
{
    public class Commission : Hourly
    {
        public double TotalSales { get; set; }
        private double CommissionRate { get; }
        
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) :
            base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            CommissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            TotalSales += totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay() + TotalSales;
            TotalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTotal sales: " + TotalSales;
        }
    }
}