﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSystem.Abstract;

namespace GameSystem.Entities
{
    public class Gamer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }

        public DateTime DateOfBirth { get; set; }
        public double Balance { get; set; }
    }
}
