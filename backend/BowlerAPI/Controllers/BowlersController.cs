using BowlerAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BowlerAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private readonly IBowlersRepository _bowlersRepository;

        public BowlersController(IBowlersRepository bowlersRepository)
        {
            _bowlersRepository = bowlersRepository;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            // Call the repository method to get bowlers with their associated teams
            var bowlersWithTeams = _bowlersRepository.GetBowlersWithTeams();
            return bowlersWithTeams;
        }
    }
}

