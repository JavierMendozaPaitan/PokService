using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WAppDomBase.Interfaces.Serialize
{
    public interface IJsnDes
    {
        Task<T> Deserialize<T>(Stream stream);
        T Deserialize<T>(string str);
    }
}
