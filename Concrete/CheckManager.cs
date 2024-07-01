using Deneme.Abstract;
using Deneme.Entities;
using Deneme.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.Concrete
{
    public class CheckManager : ICheckService
    {
        public bool isValidate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalityIdentity), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear);
        }
    }
}
