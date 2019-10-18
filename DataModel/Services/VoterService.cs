using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModel.Models;

namespace DataModel.Services
{
    public class VoterService
    {
        private readonly IMongoCollection<Voter> _voters;

        public VoterService()
        {
            _voters = DBConnection.Connect().GetCollection<Voter>("Voters");
        }

        public List<Voter> Get() =>
            _voters.Find(voter => true).ToList();

        public Voter Get(int ci) =>
            _voters.Find<Voter>(voter => voter.Ci == ci).FirstOrDefault();

        public Voter Create(Voter voter)
        {
            _voters.InsertOne(voter);
            return voter;
        }

        public void Update(string id, Voter voterIn) =>
            _voters.ReplaceOne(voter => voter._id == id, voterIn);

        public void Remove(Voter voterIn) =>
            _voters.DeleteOne(voter => voter._id == voterIn._id);

        public void Remove(string id) =>
            _voters.DeleteOne(voter => voter._id == id);
    }
}