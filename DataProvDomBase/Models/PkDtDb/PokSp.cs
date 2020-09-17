using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace DataProvDomBase.Models.PkDtDb
{
    public class PokSp
    {
        [BsonElement(" Attack")]
        public int Attack { get; set; }
        [BsonElement(" Defense")]
        public int Defense { get; set; }
    }
}
