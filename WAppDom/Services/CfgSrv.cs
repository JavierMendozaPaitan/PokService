using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WAppDom.Actions;
using WAppDomBase.Bases.Srvs;

namespace WAppDom.Services
{
    public class CfgSrv : CfgSrvBase
    {
        public CfgSrv(IConfiguration cfg)
        {
            try
            {
                Cfg = new CfgOptActions(cfg);

            }
            catch (Exception)
            {
                throw;
            }
        }

        private CfgOptActions Cfg;


        public override T CfgOpt<T>()
        {
            try
            {
                return Cfg.CfgOptGet<T>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
