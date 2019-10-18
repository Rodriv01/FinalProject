using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataModel.Models
{
    [BsonIgnoreExtraElements]
    public class Candidate
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("imgPath")]
        public string ImgPath { get; set; }
        [BsonElement("position")]
        public string Position { get; set; }
    }
}