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
    public class PartyController : ApiController
    {
        private readonly PartyService _partyService;
        public PartyController()
        {
            _partyService = new PartyService();
        }
        public Party Get(string abbreviation)
        {
            return _partyService.Get(abbreviation);
        }
        public List<Party> GetAll()
        {
            return _partyService.Get();
        }
        public void Delete(Party party)
        {
            _partyService.Remove(party);
        }
        public void Insert(Party party)
        {
            _partyService.Create(party);
        }
        public void Update(string id, Party partyIn)
        {
            _partyService.Update(id, partyIn);
        }
    }
}
