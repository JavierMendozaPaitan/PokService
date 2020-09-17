using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAppDomBase.Interfaces.Models
{
    public interface IDbDat
    {
        string Id { get; }
        int IntId { get; }
        DateTime CreateDate { get; set; }
        DateTime LastUpdate { get; set; }
    }
}
