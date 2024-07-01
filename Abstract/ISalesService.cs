using Deneme.Concrete;
using Deneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.Abstract
{
    public interface ISalesService
    {
        void MakeSale(Gamer gamer,CampaignManager campaignManager,Campaign campaign);
    }
}
