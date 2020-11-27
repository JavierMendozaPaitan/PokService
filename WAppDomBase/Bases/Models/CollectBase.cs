using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAppDomBase.Interfaces.Models;

namespace WAppDomBase.Bases.Models
{
    public abstract class CollectBase : ICollect
    {
        public abstract string Id { get; }
        public abstract long? SysTrace { get; }
        public abstract DateTime CreatedOn { get; set; }
        public abstract DateTime UpdatedOn { get; set; }
    }
}
