﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Infra
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DatabaseName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }

}
