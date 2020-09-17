using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using WAppDomBase.Bases.Dbs;
using WAppDomBase.Interfaces.Dbs;
using WAppDomBase.Interfaces.Models;

namespace WAppDom.Actions
{
    public class MgCollActions<T> : MgCollBase<T> where T : new()
    {
        public MgCollActions(IMgDb mgdb, string name)
            : base(mgdb, name)
        {
            try
            {
                coll = MgDb.Db.GetCollection<T>(Name);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private IMongoCollection<T> coll;

        public override IMongoCollection<T> Collection => coll;

        public override T SelectById(string id)
        {
            try
            {
                var obj = coll.Find(x => ((IDbDat)x).Id == id).FirstOrDefault();

                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T SelectById(int id)
        {
            try
            {
                var obj = coll.Find(x => ((IDbDat)x).IntId == id).FirstOrDefault();

                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
