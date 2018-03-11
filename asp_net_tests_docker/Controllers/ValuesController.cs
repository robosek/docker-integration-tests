using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace asp_net_tests_docker.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly MasterContext _masterContext = new MasterContext();
        
        [HttpGet]
        public IEnumerable<TestUser> Get()
        {
            return _masterContext.TestUser.ToList();
        }
    }
}
