using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WAppDomBase.Interfaces.HttpReq
{
    public interface IHttpRq
    {
        IHttpClientFactory ClientFact { get; }
        HttpClient HClient { get; }
        Task<string> ContentAsString(string url);
        Task<U> ContentAsType<U>(string url);
    }
}
