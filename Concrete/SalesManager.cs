using Deneme.Abstract;
using Deneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.Concrete
{
    public class SalesManager : ISalesService
    {
        public void MakeSale(Gamer gamer, CampaignManager campaignManager,Campaign campaign)
        {
            Console.Write(gamer.FirstName + " için ");
            campaignManager.Use(campaign);
            Console.WriteLine(" ve satış gerçekleştirildi.");
        }
    }
}
