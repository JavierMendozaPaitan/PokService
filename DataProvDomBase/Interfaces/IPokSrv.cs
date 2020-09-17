using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvDomBase.Models.PkDtDb;
using DataProvDomBase.Reports;

namespace DataProvDomBase.Interfaces
{
    public interface IPokSrv
    {
        Func<string, Task<PokDat>> ShowPok { get; }
        Func<string, Task<PokDatLst>> FilterPoks { get; }
        Func<string, string, Task<PokDatLst>> FilterOptPoks { get; }
    }
}
