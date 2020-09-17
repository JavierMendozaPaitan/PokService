using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WAppDomBase.Interfaces.Config
{
    public interface ICfgOpt
    {
        IConfiguration Cfg { get; }
        T CfgOptGet<T>();
    }
}
