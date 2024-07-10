using GameSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Entities
{
    public class Game : IEntity
    {
        public Campaign campaign { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

       


    }
}
