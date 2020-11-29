using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WppDomBase.Interfaces.Dbs;

namespace DataProvDomBase.Interfaces
{
    public interface IPokMgDb
    {
        IMgDb MgDb { get; }
    }
}
