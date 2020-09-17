using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAppDomBase.Config;

namespace WAppDomBase.Interfaces.Config
{
    public interface IDbInf
    {
        string Name { get; set; }
        DbSetting Setting { get; set; }
    }
}
