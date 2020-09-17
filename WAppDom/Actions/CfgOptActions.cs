using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WAppDomBase.Bases.Config;

namespace WAppDom.Actions
{
    public class CfgOptActions : CfgOptBase
    {
        public CfgOptActions(IConfiguration cfg)
            :base(cfg)
        {

        }

        public override T CfgOptGet<T>() 
        {
            try
            { 
                T cfgopt = Cfg.GetSection(typeof(T).Name).Get<T>();

                return cfgopt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
