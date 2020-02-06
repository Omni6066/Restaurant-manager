﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManager.Core.Interfaces
{
    interface ITokenProvider
    {
        string GenerateToken(int expiresIn);
    }
}
