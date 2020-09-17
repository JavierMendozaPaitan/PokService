using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WAppDomBase.Interfaces.HttpReq;

namespace WAppDomBase.Bases.HttpReq
{
    public abstract class HttpRqBase : IHttpRq
    {
        public HttpRqBase(IHttpClientFactory clifact)
        {
            ClientFact = clifact;
        }

        public IHttpClientFactory ClientFact { get; }

        public abstract HttpClient HClient { get; }
        public abstract Task<string> ContentAsString(string url);
        public abstract Task<U> ContentAsType<U>(string url);
    }
}
