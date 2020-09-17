using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvDomBase.Config.MongoDb;
using WAppDomBase.Interfaces;

namespace DataProvDomBase.Interfaces
{
    public interface IPokParm
    {
        PokDataDb PkDat { get; }
    }
}
