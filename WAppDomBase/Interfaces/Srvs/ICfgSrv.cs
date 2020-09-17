using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAppDomBase.Interfaces.Srvs
{
    public interface ICfgSrv
    {
        T CfgOpt<T>();
    }
}
