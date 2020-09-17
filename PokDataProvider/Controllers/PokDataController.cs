using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataProvDom.Items;
using DataProvDomBase.Interfaces;
using DataProvDomBase.Models.PkDtDb;
using DataProvDomBase.Reports;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Driver;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PokDataProvider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokDataController : ControllerBase
    {
        public PokDataController(IPokParm parm, IPokMgDb mdb)
        {
            pkprm = (PokParm)parm;
            pdb = (PokMgDb)mdb;
        }
        private PokParm pkprm;
        private PokMgDb pdb;

        // GET: api/<PokDataController>
        [HttpGet("/Welcome")]
        public string Welcome()
        {
            return $"Welcome Friends";
        }

        [HttpGet]
        public ActionResult<PokDat> Get(int id)
        {
            var pok = pdb.PokDat.SelectById(id);

            return Ok(pok);
        }

        [HttpGet("Init")]
        public ActionResult<PokDatLst> Get()
        {
            var lst = new List<PokDat>();
            int i = 1;
            while (i < 10)
            {
                var pok = pdb.PokDat.SelectById(i);
                lst.Add(pok);
                i++;
            }
            var pklst = new PokDatLst
            {
                Count = 9,
                Lst = lst
            };

            return Ok(pklst);
        }

        [HttpGet("Filter")]
        public ActionResult<PokDatLst> Get(string text)
        {
            var lst = !string.IsNullOrEmpty(text) ? pdb.SelectByName(text) : pdb.SelectFirstNine();
            var pklst = new PokDatLst
            {
                Count = 9,
                Lst = lst,
            };

            return Ok(pklst);
        }

        [HttpGet("FilterOpts")]
        public ActionResult<PokDatLst> Get(string text, string opt)
        {
            var lst = string.IsNullOrEmpty(text) ? pdb.SelectFirstNine() 
                : !string.IsNullOrEmpty(opt) ? pdb.SelectByOpt(text, opt) 
                : pdb.SelectFirstNine();
            var slst = new List<SelectListItem>();
            var sopt = new SelectListItem { Value = "Id", Text = "Id" };
            slst.Add(sopt);
            sopt = new SelectListItem { Value = "Name", Text = "Name" };
            slst.Add(sopt);

            var pklst = new PokDatLst
            {
                Count = lst.Count,
                Lst = lst,
                SelOpts = slst,
                PokSelect = opt,
                Text = text
            };

            return Ok(pklst);
        }
    }
}
