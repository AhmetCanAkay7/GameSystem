﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSystem.Entities;

namespace GameSystem.Abstract
{
    public interface IGamerCheckService
    {
        bool isValidate(Gamer gamer);

    }
}
