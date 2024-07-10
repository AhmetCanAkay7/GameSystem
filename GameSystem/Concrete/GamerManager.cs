using GameSystem.Abstract;
using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace GameSystem.Concrete
{
    public class GamerManager : IGamerService 
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
           if(_gamerCheckService.isValidate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " kaydı eklendi.");
            }
            else
            {
                throw new Exception("Doğrulama başarısız. Kayıt eklenemedi.");
            }
            //KPSPublicSoapClient client = new KPSPublicSoapClient();
            //client.TCKimlikNoDogrula(Convert.ToInt

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "'ın kaydı silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "'ın bilgileri güncellendi.");
        }
       
    }
}
