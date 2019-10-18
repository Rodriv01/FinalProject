using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataModel.Models
{
    [BsonIgnoreExtraElements]
    public class Party
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("logoPath")]
        public string LogoPath { get; set; }
        [BsonElement("abbreviation")]
        public string Abbreviation { get; set; }
        [BsonElement("numOfVotes")]
        public int NumOfVotes { get; set; }
        [BsonElement("candidates")]
        public List<Candidate> Candidates { get; set; }
    }
}