﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WAppDomBase.Interfaces
{
    public interface IParm
    {
        IConfiguration Cfg { get; }
    }
}