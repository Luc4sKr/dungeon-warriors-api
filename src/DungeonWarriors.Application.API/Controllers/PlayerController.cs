using DungeonWarriors.Domain.DTO;
using DungeonWarriors.Domain.Entities;
using DungeonWarriors.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;


namespace DungeonWarriors.Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            this._playerService = playerService;
        }

        [HttpGet]
        public ActionResult<List<PlayerDTO>> Get()
        {
            try
            {
                return _playerService.FindAll();
            }
            catch
            {
                return NotFound();
            }
        }

        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlayerController>
        [HttpPost]
        public async Task<ActionResult<PlayerDTO>> Post([FromBody] Player player)
        {
            await _playerService.Save(player);
            return Ok();
        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
