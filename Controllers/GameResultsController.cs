using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BPServer.Controllers
{
    [Route("api/[controller]")]
    public class GameResultsController : Controller
    {
        // POST api/gameresults
        [HttpPost]
        public void Post([FromBody]GameResults results)
        {
            GameRoom.Instance.AddGameResults(results);
        }
    }
}
