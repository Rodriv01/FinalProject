using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Services
{
    public static class DBConnection
    {
        public static IMongoDatabase Connect()
        {
            var client = new MongoClient("mongodb+srv://LomitoTriste:lenovo@cluster0-2j51w.mongodb.net/test?retryWrites=true&w=majority");
            return client.GetDatabase("TSEVoteProject");
        }
    }
}