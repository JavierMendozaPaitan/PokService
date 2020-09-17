using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using WAppDomBase.Interfaces.Config;

namespace WAppDomBase.Interfaces.Dbs
{
    public interface IMgDb
    {
        IDbInf DbInfo { get; }
        string Name { get; }
        IMongoClient Client { get; }
        IMongoDatabase Db { get; }
    }
}
