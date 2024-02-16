using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using TarifDostuApi.Data;
using TarifDostuApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TarifDostuApi.Controllers
{
    [Route("api/ingrediements")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly ILogger<IngredientsController> _logger;

        public IngredientsController(ILogger<IngredientsController> logger) // Dependency Injection ile loggerı projeye ekliyorum.
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllIngrediements()
        {
            var result = ApplicationContext.Ingredients;
            _logger.LogInformation("Malzemeler istendi.");
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetIngrediement([FromRoute(Name = "id")] int id)
        {
            _logger.LogInformation("ID: "+id+" Malzeme Getirildi.");
            var ingredient = ApplicationContext.Ingredients.Where(b => b.Id == id).SingleOrDefault();
            if (ingredient == null) { return NotFound(); }
            return Ok(ingredient);
        }
        [HttpPost]
        public IActionResult CreateIngrediement([FromBody] Ingredient ingredient)
        {
            try
            {
                if (ingredient is null)
                {
                    return BadRequest();
                }
                ApplicationContext.Ingredients.Add(ingredient);
                _logger.LogInformation("Malzeme Eklendi.");
                return StatusCode(201, ingredient);
                 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateIngrediement([FromRoute (Name ="id")] int id, [FromBody] Ingredient ingredient)
        {
            var entity = ApplicationContext.Ingredients.Find(i => i.Id.Equals(id));
            if (entity == null)
                return NotFound();
            if (id != entity.Id)
                return BadRequest();
            ApplicationContext.Ingredients.Remove(entity);
            ingredient.Id = entity.Id;
            ApplicationContext.Ingredients.Add(ingredient);
            _logger.LogInformation("Malzeme Güncellendi.");
            return Ok(ingredient); 
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteIngrediement([FromRoute (Name ="id")] int id )
        {
            var entity = ApplicationContext.Ingredients.Find(k => k.Id.Equals(id));
            if (entity == null )
                    return NotFound(
                        new
                        {
                            statusCode = 404,
                            message = $"Ingrediment with id:{id} could not found. It was probably already deleted."
                        });
            ApplicationContext.Ingredients.Remove(entity);
            _logger.LogInformation("Malzeme Silindi.");
            return StatusCode(204);
        }

        [HttpDelete]
        public IActionResult DeleteAllIngrediements()
        {
            ApplicationContext.Ingredients.Clear();
            _logger.LogInformation("Tüm Malzemeler Silindi.");
            return StatusCode(204);
        }

        [HttpPatch("{id:int}")]
        public IActionResult PartiallyUpdateOneBook([FromRoute(Name ="id")] int id, [FromBody] JsonPatchDocument<Ingredient> ingredient)
        {
            var entity = ApplicationContext.Ingredients.Find(i => i.Id.Equals(id));
            if (entity == null)
                return NotFound( new
                {
                    statusCode=404,
                    message= $"Ingrediment with id:{id} could not found. It was probably already deleted."
                });
            if (!entity.Id.Equals(id))
                return BadRequest();
            ingredient.ApplyTo(entity);
            _logger.LogInformation("Malzeme Patch yoluyla güncellendi.");
            return StatusCode(204);
        }

    }
}
