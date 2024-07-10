using GameSystem.Abstract;
using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool isValidate(Gamer gamer)
        {
            if(gamer.FirstName== "Ahmet Can" && gamer.LastName == "Akay" && gamer.NationalityId == "15730522050" && gamer.DateOfBirth.Year == 2003)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
