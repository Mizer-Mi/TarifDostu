using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Linq.Expressions;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/ingrediements")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public IngredientsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllIngrediements()
        {
          return Ok(_manager.IngredientService.GetIngredients(true));
          
        }

        [HttpGet("{id:int}")]
        public IActionResult GetIngrediement([FromRoute(Name = "id")] int id)
        {
            var ingredient = _manager.IngredientService.GetIngredient(id, true);
            
            return Ok(ingredient);
        }
        [HttpPost]
        public IActionResult CreateIngrediement([FromBody] Ingredient ingredient)
        {
                if (ingredient is null)
                {
                    return BadRequest();
                }
                _manager.IngredientService.CreateIngredient(ingredient);
                return StatusCode(201, ingredient);
        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateIngrediement([FromRoute (Name ="id")] int id, [FromBody] IngredientDtoForUpdate ingredient)
        {
            if (id != ingredient.Id)
                return BadRequest();

            _manager.IngredientService.UpdateIngredient(id,ingredient,false);
            return Ok(); 
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteIngrediement([FromRoute (Name ="id")] int id )
        {
            _manager.IngredientService.DeleteIngredient(id,true);
            return StatusCode(204);
        }

        [HttpDelete]
        public IActionResult DeleteAllIngrediements()
        {
            return StatusCode(204);
        }

        [HttpPatch("{id:int}")]
        public IActionResult PartiallyUpdateOneBook([FromRoute(Name ="id")] int id, [FromBody] JsonPatchDocument<IngredientDtoForUpdate> ingredient)
        {
            var entity = _manager.IngredientService.GetIngredient(id,true);
    //        ingredient.ApplyTo(entity);
      //      _manager.IngredientService.UpdateIngredient(id,entity,true);
            return StatusCode(204);
        }

    }
}
