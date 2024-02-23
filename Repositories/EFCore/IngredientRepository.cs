using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class IngredientRepository : RepositoryBase<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateIngredient(Ingredient ingredient) => Create(ingredient);

        public void DeleteIngredient(Ingredient ingredient) => Delete(ingredient);

        public IQueryable<Ingredient> GetIngredients(bool trackChanges) => GetAll(trackChanges);
        public Ingredient GetIngredient(int id, bool trackChanges) => Get(x => x.Id == id, trackChanges).SingleOrDefault(); 

        public void UpdateIngredient(Ingredient ingredient)=> Update(ingredient);
    }
}
