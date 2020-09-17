using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WAppDomBase.Interfaces.Config;

namespace WAppDomBase.Bases.Config
{
    public abstract class CfgOptBase : ICfgOpt
    {
        public CfgOptBase(IConfiguration cfg)
        {
            Cfg = cfg;
        }
        public IConfiguration Cfg { get; }

        public abstract T CfgOptGet<T>();
    }
}
