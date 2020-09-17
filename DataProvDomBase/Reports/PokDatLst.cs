using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvDomBase.Models.PkDtDb;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DataProvDomBase.Reports
{
    public class PokDatLst
    {
        public int Count { get; set; }
        public List<PokDat> Lst { get; set; }
        //public SelectList SelOpts { get; set; }
        public List<SelectListItem> SelOpts { get; set; }
        public string PokSelect { get; set; }
        public string Text { get; set; }
    }
}
