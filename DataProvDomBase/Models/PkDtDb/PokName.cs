using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace DataProvDomBase.Models.PkDtDb
{
    public class PokName
    {
        [BsonElement("english")]
        public string English { get; set; }
        [BsonElement("japanese")]
        public string Japanese { get; set; }
        [BsonElement("chinese")]
        public string Chinese { get; set; }
        [BsonElement("french")]
        public string French { get; set; }
    }
}
