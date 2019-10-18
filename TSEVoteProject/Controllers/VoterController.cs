using DataModel.Models;
using DataModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TSEVoteProject.Controllers
{
    public class VoterController : ApiController
    {
        private readonly VoterService _voterService;
        public VoterController()
        {
            _voterService = new VoterService();
        }
        public Voter Get(int ci)
        {
            return _voterService.Get(ci);
        }
        public List<Voter> GetAll()
        {
            return _voterService.Get();
        }
        public void Delete(Voter voter)
        {
            _voterService.Remove(voter);
        }
        public void Insert(Voter voter)
        {
            _voterService.Create(voter);
        }
        public void Update(string id, Voter voter)
        {
            _voterService.Update(id, voter);
        }
    }
}
