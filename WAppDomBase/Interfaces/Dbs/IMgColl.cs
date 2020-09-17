using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace WAppDomBase.Interfaces.Dbs
{
    public interface IMgColl<T>
    {
        string Name { get; }
        IMgDb MgDb { get; }
        IMongoCollection<T> Collection { get; }
        T SelectById(string id);
    }
}
