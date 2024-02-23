using Entities.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public record IngredientDtoForUpdate //readonly / immutable
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public IngredientType Type { get; init; }
        public Double EstimatedUnitPrice { get; init; }
        public UnitType Unit { get; init; }
        public bool IsCustom { get; init; }
    }
}
