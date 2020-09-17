using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WAppDomBase.Interfaces;

namespace WAppDomBase.Bases
{
    public abstract class ParmBase : IParm
    {
        public ParmBase(IConfiguration cfg)
        {
            Cfg = cfg;
        }
        public IConfiguration Cfg { get; }
    }
}
