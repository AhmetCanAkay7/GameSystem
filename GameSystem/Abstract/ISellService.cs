using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSystem.Entities;

namespace GameSystem.Abstract
{
    public interface ISellService
    {

        void Sell(Gamer gamer,Game game, List<Game> gamesWithCampaign);
    }
}
