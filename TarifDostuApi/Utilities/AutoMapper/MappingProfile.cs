using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace TarifDostuApi.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IngredientDtoForUpdate, Ingredient>();

        }
    }
}
