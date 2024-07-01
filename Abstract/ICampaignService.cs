using Deneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.Abstract
{
    public interface ICampaignService
    {
        void Use(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
