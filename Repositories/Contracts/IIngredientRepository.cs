using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IIngredientRepository : IRepositoryBase<Ingredient>
    {
        IQueryable<Ingredient> GetIngredients(bool trackChanges);
        Ingredient GetIngredient(int id,bool trackChanges);
        void CreateIngredient(Ingredient ingredient);
        void UpdateIngredient(Ingredient ingredient);
        void DeleteIngredient(Ingredient id);
    }
}
