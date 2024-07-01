using Deneme.Abstract;
using Deneme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme.Concrete
{
    public class GamerManager : IGamerService
    {
        ICheckService _checkService;

        public GamerManager(ICheckService checkService)
        {
            _checkService = checkService;
        }

        public void Add(Gamer gamer)
        {
            if (_checkService.isValidate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " kayıt edildi");
            }
            else
            {
                throw new Exception("Kullanıcı doğrulanamadı ve bu yüzden kayıt gerçekleşemiyor");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " güncellendi");
        }
    }
}
