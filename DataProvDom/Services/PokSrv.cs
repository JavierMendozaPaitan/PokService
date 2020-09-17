using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using DataProvDomBase.Bases;
using DataProvDomBase.Models.PkDtDb;
using DataProvDomBase.Reports;
using WAppDom.Actions;
using WAppDomBase.Interfaces.HttpReq;

namespace DataProvDom.Services
{
    public class PokSrv : PokSrvBase
    {
        public PokSrv(IHttpClientFactory clifact)
        {
            try
            {
                htt = new HttpRqActions(clifact);
                ShowPok = ShowPksFromProv;
                FilterPoks = FilterPksFromProv;
                FilterOptPoks = FilterPksFromProv;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private readonly HttpRqActions htt;

        public override Func<string, Task<PokDat>> ShowPok { get; }
        public override Func<string, Task<PokDatLst>> FilterPoks { get; }
        public override Func<string,string, Task<PokDatLst>> FilterOptPoks { get; }

        private async Task<PokDat> ShowPksFromProv(string id)
        {
            try
            {
                var url = $@"https://localhost:44328/api/PokData?id={id}";
                var lst = await htt.ContentAsType<PokDat>(url);

                return lst;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<PokDatLst> FilterPksFromProv(string text)
        {
            try
            {
                var url = $@"https://localhost:44328/api/PokData/Filter?text={text}";
                var lst = await htt.ContentAsType<PokDatLst>(url);

                return lst;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<PokDatLst> FilterPksFromProv(string text, string opt)
        {
            try
            {
                var url = $@"https://localhost:44328/api/PokData/FilterOpts?text={text}&opt={opt}";
                var lst = await htt.ContentAsType<PokDatLst>(url);

                return lst;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
