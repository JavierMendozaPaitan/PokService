using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvDomBase.Config.MongoDb;
using DataProvDomBase.Interfaces;
using Microsoft.Extensions.Configuration;
using WAppDom.Services;
using WAppDomBase.Bases;

namespace DataProvDom.Items
{
    public class PokParm : ParmBase, IPokParm
    {
        public PokParm(IConfiguration cfg)
            : base(cfg)
        {
            try
            {
                cfgsrv = new CfgSrv(cfg);
                PkDat = cfgsrv.CfgOpt<PokDataDb>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private CfgSrv cfgsrv;

        public PokDataDb PkDat { get; }
    }
}
