using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Exceptions;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class IngredientManager : IIngredientService
    {
        private readonly IRepositoryManager _manager;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public IngredientManager(IRepositoryManager manager, ILoggerService logger,IMapper mapper)
        {
            _manager = manager;
            _logger = logger;
            _mapper=mapper;
        }

        public Ingredient CreateIngredient(Ingredient ingredient)
        {
           _manager.Ingredients.Create(ingredient);
            _manager.Save();
            return ingredient;
        }

        public void DeleteIngredient(int id, bool trackChanges)
        {
            var ingredient = _manager.Ingredients.GetIngredient(id,trackChanges);
            if (ingredient is null)
                throw new IngredientNotFoundException(id);
            _manager.Ingredients.DeleteIngredient(ingredient);
            _manager.Save();
        }

        public Ingredient GetIngredient(int id, bool trackChanges)
        {
            var ingredient = _manager.Ingredients.GetIngredient(id,trackChanges);
            if (ingredient is null)
                throw new IngredientNotFoundException(id);
            return ingredient;
        }

        public IEnumerable<Ingredient> GetIngredients(bool trackChanges)
        {
          return _manager.Ingredients.GetIngredients(trackChanges);
        }

        public void UpdateIngredient(int id, IngredientDtoForUpdate ingredientDto, bool trackChanges)
        {
            var entity = _manager.Ingredients.GetIngredient(id, trackChanges);
            if (entity is null)
                throw new IngredientNotFoundException(id);
            entity = _mapper.Map<Ingredient>(ingredientDto);
            _manager.Ingredients.Update(entity);
            _manager.Save();
        }
    }
}
