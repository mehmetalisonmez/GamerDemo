using Deneme.Concrete;
using Deneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.FirstName = "Ali";

            StudentCampaign studentCampaign = new StudentCampaign();
            studentCampaign.CampaignName = "Öğrenci kampanyası";
            
            CampaignManager campaignManager = new CampaignManager();

            SalesManager salesManager = new SalesManager();
            salesManager.MakeSale(gamer,campaignManager,studentCampaign);

            Console.ReadLine();
        }
    }
}
