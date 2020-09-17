using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using WAppDomBase.Interfaces.Models;

namespace DataProvDomBase.Models.PkDtDb
{
    public class PokDat : IDbDat
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("id")]
        public int IntId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        [BsonElement("name")]
        public PokName Name { get; set; }
        [BsonElement("type")]
        public List<string> Type { get; set; }
        [BsonElement("base")]
        public BaseSkills Base { get; set; }
    }
}
