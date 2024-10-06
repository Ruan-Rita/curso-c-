using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using sharp_project.Model;
using sharp_project.Business;

namespace sharp_project.Controllers
{
    [ApiVersion(1)]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        private IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personBusiness.FindById(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpPost()]
        public IActionResult Create([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest("Data bad formed");
            }
            var newPerson = _personBusiness.Create(person);
            return Ok(newPerson);
        }

        [HttpPut()]
        public IActionResult Update([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest("Data bad formed");
            }
            var newPerson = _personBusiness.Update(person);
            return Ok(newPerson);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return Ok("Person deleted successfully");
        }
    }
}
