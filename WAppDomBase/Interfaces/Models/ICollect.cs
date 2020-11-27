using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAppDomBase.Interfaces.Models
{
    public interface ICollect
    {
        string Id { get; }
        long? SysTrace { get; }
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
    }
}
