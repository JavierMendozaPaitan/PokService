using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAppDomBase.Interfaces.Dbs;

namespace DataProvDomBase.Interfaces
{
    public interface IPokMgDb
    {
        IMgDb MgDb { get; }
    }
}
