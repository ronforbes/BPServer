using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BPServer.Controllers
{
    [Route("api/[controller]")]
    public class GameRoomController : Controller
    {
        // GET api/gameroom
        [HttpGet]
        public GameRoom Get()
        {
            return GameRoom.Instance;
        }
    }
}
