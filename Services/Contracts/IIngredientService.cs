using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IIngredientService
    {
        IEnumerable<Ingredient> GetIngredients(bool trackChanges);
        Ingredient GetIngredient(int id, bool trackChanges);
        void UpdateIngredient(int id,IngredientDtoForUpdate ingredientDto, bool trackChanges);
        void DeleteIngredient(int id, bool trackChanges);
        Ingredient CreateIngredient(Ingredient ingredient);

    }
}
