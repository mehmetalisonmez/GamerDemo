using Deneme.Abstract;
using Deneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.Concrete
{
    public class CampaignManager : ICampaignService
    { 
        public void Use(Campaign campaign)
        {
            Console.Write(campaign.CampaignName + " kampanyası uygulandı.");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası güncellendi.");
        }

    }
}
