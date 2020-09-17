using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using WAppDomBase.Bases.Dbs;
using WAppDomBase.Config;
using WAppDomBase.Interfaces.Config;

namespace WAppDom.Actions
{
    public class MgDbActions : MgDbBase
    {
        public MgDbActions(IDbInf info)
            :base(info)
        {
            try
            {
                sett = DbInfo.Setting;
                Name = DbInfo.Name;
                Client = new MongoClient(sett.ConnectionString);
                Db = Client.GetDatabase(Name);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private readonly DbSetting sett;

        public override string Name { get; }
        public override IMongoClient Client { get; }
        public override IMongoDatabase Db { get; }

    }
}
