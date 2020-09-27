using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeyBOard.DTO;
using KeyBOard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KeyBOard.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KeyBoardController : ControllerBase
    {


        private SellContext db = new SellContext();
        private readonly ILogger<KeyBoardController> _logger;

        public KeyBoardController(ILogger<KeyBoardController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<KeyBoardDTO> Get()
        {
            var keyBoards = from x in db.KeyBoards
                            select new KeyBoardDTO()
                            {
                                Id = x.Id,
                                Name = x.Name,
                                GuaranteeTime = x.GuaranteeTime,
                                Price = x.Price
                            };
            return keyBoards;
        }
        [HttpPost]
        public void Post([FromBody] string name, int guarantee, int price)
        {
            KeyBoardDTO x = new KeyBoardDTO();
            x.Name = name;
            x.GuaranteeTime = guarantee;
            x.Price = price;
            db.KeyBoards.Add(x);
        }
    }
}
