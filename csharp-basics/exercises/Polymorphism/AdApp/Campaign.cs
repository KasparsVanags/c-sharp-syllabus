using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> campaign;

        public Campaign() 
        {
            campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            campaign.Add(a);
        }

        public double GetCost()
        {
            return campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            return campaign.Aggregate("Advert Campaign", (c, ad) => c + ad) + "\nTotal Cost = " + GetCost();
        }
    }
}