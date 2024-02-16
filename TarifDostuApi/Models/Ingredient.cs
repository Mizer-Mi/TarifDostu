namespace TarifDostuApi.Models
{
    // Mizer-Mi - TarifDostu Projesi
    // Malzemenin Modelini tanıtıyoruz.
    //
    public class Ingredient
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Double Quantity { get; set; }
        public string Unit { get; set; }
        public bool IsCustom {get;set;}
    }

}
