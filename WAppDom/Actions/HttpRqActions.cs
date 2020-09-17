using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WAppDomBase.Bases.HttpReq;

namespace WAppDom.Actions
{
    public class HttpRqActions : HttpRqBase
    {
        public HttpRqActions(IHttpClientFactory clifact)
            :base(clifact)
        {
            try
            {
                HClient = ClientFact.CreateClient();
                jsd = new JsnDesActions();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private JsnDesActions jsd;

        public override HttpClient HClient { get; }

        public JsnDesActions JnDs { get; }

        public override async Task<string> ContentAsString(string url)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = await HClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var str = await response.Content.ReadAsStringAsync();

                return str;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override async Task<U> ContentAsType<U>(string url)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = await HClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var strm = await response.Content.ReadAsStreamAsync();
                U obj = await jsd.Deserialize<U>(strm);
                //var str = await response.Content.ReadAsStringAsync();
                //U obj = jsd.Deserialize<U>(str);

                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
