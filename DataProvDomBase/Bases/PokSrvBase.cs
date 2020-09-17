using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvDomBase.Interfaces;
using DataProvDomBase.Models.PkDtDb;
using DataProvDomBase.Reports;

namespace DataProvDomBase.Bases
{
    public abstract class PokSrvBase : IPokSrv
    {
        public abstract Func<string, Task<PokDat>> ShowPok { get; }
        public abstract Func<string, Task<PokDatLst>> FilterPoks { get; }
        public abstract Func<string, string, Task<PokDatLst>> FilterOptPoks { get; }
    }
}
