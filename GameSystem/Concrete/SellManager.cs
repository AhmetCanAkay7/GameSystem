using GameSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSystem.Entities;

namespace GameSystem.Concrete
{
    public class SellManager : ISellService
    {
        public void Sell(Gamer gamer, Game game , List<Game> gamesWithCampaign)
        {
            Console.WriteLine("Kampanya dahilinde olan oyunlar:");
            foreach (var games in gamesWithCampaign)
            {
                Console.WriteLine(games.Name);
            }
            Console.WriteLine("-----------------------");
            if (gamesWithCampaign.Contains(game))
            {
                game.Price = game.Price - (game.campaign.Discount) * 100;
            }

            if(gamer.Balance>=game.Price)
            {
                Console.WriteLine("Satın alma işlemi başarılı");
                Console.WriteLine("Satın alınan oyun: "+game.Name);
                Console.WriteLine("Ödenen tutar: "+game.Price);
                Console.WriteLine("Kalan bakiye: "+(gamer.Balance-game.Price));
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye");
                Console.WriteLine("Bakiye: " + gamer.Balance);
                Console.WriteLine("Oyun fiyatı: " + game.Price);


        }

       
    }
    }

