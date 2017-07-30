using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using core.lab2.Models;
using core.lab2.Filters;

namespace core.lab2.Controllers
{
    [ValidateModel]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //private readonly GeoToastDbContext _dbContext;
        private readonly IMapper _mapper;

        public ValuesController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody]WebsiteCreateModel model)
        {
            var website = _mapper.Map<Website>(model);



            if (ModelState.IsValid)
            {
                // Code omitted for brevity...
                //_dbContext.Websites.Add(website);
                //await _dbContext.SaveChangesAsync();

                return CreatedAtAction("Get", new { id = website.Id }, _mapper.Map<WebsiteReadModel>(website));
            }

            return BadRequest();

        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
