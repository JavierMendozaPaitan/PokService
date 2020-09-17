using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAppDomBase.Interfaces.Srvs;

namespace WAppDomBase.Bases.Srvs
{
    public abstract class CfgSrvBase : ICfgSrv
    {
        public abstract T CfgOpt<T>();
    }
}
