﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeedLord.Dto;

namespace SpeedLord.Interfaces.Repositories
{
    public interface IRealmRepository
    {
        Realm GetRealmById(int id);
        IEnumerable<Realm> GetAllRealms();
    }
}
