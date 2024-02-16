using Microsoft.AspNetCore.Mvc;
using TarifDostuApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TarifDostuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly ILogger<IngredientsController> _logger;

        public IngredientsController(ILogger<IngredientsController> logger) // Dependency Injection ile loggerı projeye ekliyorum.
        {
            _logger = logger;
        }

        // GET: api/<IngredientsController>
        [HttpGet]
        public IActionResult GetAllIngrediements()
        {
            var result = DemoOlusturma.MalzemelerDemo();
            _logger.LogInformation("Malzemeler istendi.");
            return Ok(result);
        }

        // POST api/<IngredientsController>
        [HttpPost]
        public IActionResult CreateCustomIngrediement([FromBody] string value)
        {
            _logger.LogWarning("Malzeme Oluşturuldu.");
            return StatusCode(201);
        }

     
    }
}
