using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using WAppDomBase.Interfaces.Dbs;

namespace WAppDomBase.Bases.Dbs
{
    public abstract class MgCollBase<T> : IMgColl<T>
    {
        public MgCollBase(IMgDb mgdb, string name)
        {
            MgDb = mgdb;
            Name = name;
        }

        public IMgDb MgDb { get; }
        public string Name { get; }

        public abstract IMongoCollection<T> Collection { get; }
        public abstract T SelectById(string id);
    }
}
