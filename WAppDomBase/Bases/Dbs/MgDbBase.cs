using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using WAppDomBase.Interfaces.Config;
using WAppDomBase.Interfaces.Dbs;

namespace WAppDomBase.Bases.Dbs
{
    public abstract class MgDbBase : IMgDb
    {
        public MgDbBase(IDbInf info)
        {
            DbInfo = info;
        }

        public  IDbInf DbInfo { get; }
        
        public abstract string Name { get; }
        public abstract IMongoClient Client { get; }
        public abstract IMongoDatabase Db { get; }
    }
}
