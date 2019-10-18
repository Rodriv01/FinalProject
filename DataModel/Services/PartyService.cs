using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModel.Models;

namespace DataModel.Services
{
    public class PartyService
    {
        private readonly IMongoCollection<Party> _parties;

        public PartyService()
        {
            _parties = DBConnection.Connect().GetCollection<Party>("Party");
        }

        public List<Party> Get() =>
            _parties.Find(book => true).ToList();

        public Party Get(string abbreviation) =>
            _parties.Find<Party>(party => party.Abbreviation == abbreviation).FirstOrDefault();

        public Party Create(Party party)
        {
            _parties.InsertOne(party);
            return party;
        }

        public void Update(string id, Party partyIn) =>
            _parties.ReplaceOne(party => party._id == id, partyIn);

        public void Remove(Party partyIn) =>
            _parties.DeleteOne(party => party._id == partyIn._id);

        public void Remove(string id) =>
            _parties.DeleteOne(party => party._id == id);
    }
}