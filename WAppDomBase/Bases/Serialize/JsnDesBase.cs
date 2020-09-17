using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WAppDomBase.Interfaces.Serialize;

namespace WAppDomBase.Bases.Serialize
{
    public abstract class JsnDesBase : IJsnDes
    {
        public abstract Task<T> Deserialize<T>(Stream stream);
        public abstract T Deserialize<T>(string str);
    }
}
