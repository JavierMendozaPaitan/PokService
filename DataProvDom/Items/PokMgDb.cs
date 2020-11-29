using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using DataProvDomBase.Config.MongoDb;
using DataProvDomBase.Interfaces;
using DataProvDomBase.Models.PkDtDb;
using MongoDB.Driver;
using WppDom.Actions;
using WppDomBase.Interfaces.Dbs;

namespace DataProvDom.Items
{
    public class PokMgDb : IPokMgDb
    {
        public PokMgDb(IPokParm parm)
        {
            try
            {
                pkdat = parm.PkDat;
                mgdb = new MgDbActions(pkdat.DbInfo);
                PokDat = new MgCollActions<PokDat>(mgdb, pkdat.Pokedex.Name);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private PokDataDb pkdat;
        private MgDbActions mgdb;

        public IMgDb MgDb => mgdb;
        public MgCollActions<PokDat> PokDat { get; }

        public List<PokDat> SelectByOpt(string text, string opt)
        {
            try
            {
                var lst = new List<PokDat>();
                switch (opt)
                {
                    case "Id":
                        var pok = PokDat.SelectById(Convert.ToInt32(text));
                        lst.Add(pok);
                        break;
                    case "Name":
                        lst = SelectByName(text);
                        break;
                    default:
                        lst = SelectFirstNine();
                        break;
                }

                return lst;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PokDat> SelectByName(string text)
        {
            try
            {
                var lst = PokDat.Collection.Find(x => ((PokDat)x).Name.English.Contains(text)).ToList();

                return lst;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PokDat> SelectFirstNine()
        {
            try
            {
                var lst = PokDat.Collection.Find(x => ((PokDat)x).IntId < 10).ToList();

                return lst;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
