using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IIngredientRepository _repository;

        public RepositoryManager(RepositoryContext context, IIngredientRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public IIngredientRepository Ingredients => _repository;
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
