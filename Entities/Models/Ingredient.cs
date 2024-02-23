using Entities.Models.Enums;

namespace Entities.Models
{
    // Mizer-Mi - TarifDostu Projesi
    // Malzemenin Modelini tanıtıyoruz.
    //
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IngredientType Type { get; set; }
        public Double EstimatedUnitPrice { get; set; }
        public UnitType Unit { get; set; }
        public bool IsCustom {get;set;}
        
    }

}
