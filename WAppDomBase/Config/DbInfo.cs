using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAppDomBase.Interfaces.Config;

namespace WAppDomBase.Config
{
    public class DbInfo: IDbInf
    {
        public string Name { get; set; }
        public DbSetting Setting { get; set; }
    }
}
