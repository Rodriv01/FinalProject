using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataModel.Models
{
    [BsonIgnoreExtraElements]
    public class Voter
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("ci")]
        public int Ci { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("hasVoted")]
        public bool HasVoted { get; set; }
        [BsonElement("isAgent")]
        public bool IsAgent { get; set; }
    }
}