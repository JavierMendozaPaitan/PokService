using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WppDomBase.Config;

namespace DataProvDomBase.Config.MongoDb
{
    public class PokDataDb
    {
        public DbInfo DbInfo { get; set; }
        public Collection PokItems { get; set; }
        public Collection PokTypes { get; set; }
        public Collection Pokedex { get; set; }
    }
}
