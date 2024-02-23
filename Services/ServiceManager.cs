using AutoMapper;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IIngredientService _service;

        public ServiceManager(IIngredientService service,ILoggerService logger, IMapper mapper)
        {
            _service = service;
        }

        public IIngredientService IngredientService => _service;
    }
}
