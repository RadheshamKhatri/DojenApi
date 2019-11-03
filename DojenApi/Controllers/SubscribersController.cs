using DojenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DojenApi.Controllers
{
    public class SubscribersController : ApiController
    {
        private KTControlEntities _db;
        string Abc = string.Empty;
        public SubscribersController()
        {
            _db = new KTControlEntities();
        }
        public IEnumerable<Kt_Subscriber> GetSubscribers()
        {
            return _db.Kt_Subscriber.ToList();
        }
    }
}
