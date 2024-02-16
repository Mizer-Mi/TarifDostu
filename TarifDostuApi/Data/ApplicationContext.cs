using TarifDostuApi.Models;

namespace TarifDostuApi.Data
{
    public static class ApplicationContext
    {
        public static List<Ingredient> Ingredients { get; set; }
        static ApplicationContext()
        {
            Ingredients =
            [
             new Ingredient { Id = 1, Name = "Domates", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 0.5 },
                new Ingredient { Id = 2, Name = "Soğan", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 0.3 },
                new Ingredient { Id = 3, Name = "Tavuk Göğsü", Type = "Et", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 9.99 },
                new Ingredient { Id = 4, Name = "Yumurta", Type = "Protein", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 0.2 },
                new Ingredient { Id = 5, Name = "Sarımsak", Type = "Sebze", Unit = "diş", IsCustom = false, EstimatedUnitPrice = 0.1 },
                new Ingredient { Id = 6, Name = "Zeytinyağı", Type = "Yağ", Unit = "mililitre", IsCustom = false, EstimatedUnitPrice = 0.15 },
                new Ingredient { Id = 7, Name = "Kırmızı Biber", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 0.75 },
                new Ingredient { Id = 8, Name = "Pirinç", Type = "Tahıl", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.05 },
                new Ingredient { Id = 9, Name = "Tavuk But", Type = "Et", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 8.5 },
                new Ingredient { Id = 10, Name = "Maydanoz", Type = "Sebze", Unit = "demet", IsCustom = false, EstimatedUnitPrice = 0.5 },
                new Ingredient { Id = 11, Name = "Mercimek", Type = "Kuru Baklagil", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.1 },
                new Ingredient { Id = 12, Name = "Kaşar Peyniri", Type = "Süt Ürünü", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.3 },
                new Ingredient { Id = 13, Name = "Kıyma", Type = "Et", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 10.99 },
                new Ingredient { Id = 14, Name = "Patates", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 0.25 },
                new Ingredient { Id = 15, Name = "Un", Type = "Unlu Mamul", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.03 },
                new Ingredient { Id = 16, Name = "Yoğurt", Type = "Süt Ürünü", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.15 },
                new Ingredient { Id = 17, Name = "Limon", Type = "Meyve", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 0.5 },
                new Ingredient { Id = 18, Name = "Brokoli", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 1.0 },
                new Ingredient { Id = 19, Name = "Süt", Type = "Süt Ürünü", Unit = "mililitre", IsCustom = false, EstimatedUnitPrice = 0.2 },
                new Ingredient { Id = 20, Name = "Balık", Type = "Deniz Ürünü", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 15.99 },
                new Ingredient { Id = 21, Name = "Tereyağı", Type = "Yağ", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.2 },
                new Ingredient { Id = 22, Name = "Fesleğen", Type = "Sebze", Unit = "demet", IsCustom = false, EstimatedUnitPrice = 1.0 },
                new Ingredient { Id = 23, Name = "Kaşar Peyniri", Type = "Süt Ürünü", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.4 },
                new Ingredient { Id = 24, Name = "Kuşkonmaz", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 3.0 },
                new Ingredient { Id = 25, Name = "Kırmızı Lahana", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 1.5 },
                new Ingredient { Id = 26, Name = "Pırasa", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 0.75 },
                new Ingredient { Id = 27, Name = "Fındık", Type = "Kuruyemiş", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.5 },
                new Ingredient { Id = 28, Name = "Kabak", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 0.75 },
                new Ingredient { Id = 29, Name = "Kuşüzümü", Type = "Meyve", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.6 },
                new Ingredient { Id = 30, Name = "Badem", Type = "Kuruyemiş", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 1.0 },
                new Ingredient { Id = 31, Name = "Kırmızı Mercimek", Type = "Kuru Baklagil", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.2 },
                new Ingredient { Id = 32, Name = "Fasulye", Type = "Kuru Baklagil", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.3 },
                new Ingredient { Id = 33, Name = "Kestane", Type = "Kuruyemiş", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 2.0 },
                new Ingredient { Id = 34, Name = "Elma", Type = "Meyve", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 0.8 },
                new Ingredient { Id = 35, Name = "Mantar", Type = "Sebze", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.6 },
                new Ingredient { Id = 36, Name = "Karnabahar", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 2.0 },
                new Ingredient { Id = 37, Name = "Çilek", Type = "Meyve", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 1.2 },
                new Ingredient { Id = 38, Name = "Kuru Erik", Type = "Meyve", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.4 },
                new Ingredient { Id = 39, Name = "Ekmek", Type = "Unlu Mamul", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.05 },
                new Ingredient { Id = 40, Name = "Kırmızı Lahana", Type = "Sebze", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 1.5 },
                new Ingredient { Id = 41, Name = "Fındık", Type = "Kuruyemiş", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.5 },
                new Ingredient { Id = 42, Name = "Kabak Çekirdeği", Type = "Kuruyemiş", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.6 },
                new Ingredient { Id = 43, Name = "Limon", Type = "Meyve", Unit = "adet", IsCustom = false, EstimatedUnitPrice = 0.5 },
                new Ingredient { Id = 44, Name = "Sarımsak", Type = "Sebze", Unit = "diş", IsCustom = false, EstimatedUnitPrice = 0.1 },
                new Ingredient { Id = 45, Name = "Fesleğen", Type = "Sebze", Unit = "demet", IsCustom = false, EstimatedUnitPrice = 1.0 },
                new Ingredient { Id = 46, Name = "Zeytin", Type = "Meyve", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.7 },
                new Ingredient { Id = 47, Name = "Pirinç", Type = "Tahıl", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.1 },
                new Ingredient { Id = 48, Name = "Kuru Fasulye", Type = "Kuru Baklagil", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.2 },
                new Ingredient { Id = 49, Name = "Kahve", Type = "İçecek", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.1 },
                new Ingredient { Id = 50, Name = "Çay", Type = "İçecek", Unit = "gram", IsCustom = false, EstimatedUnitPrice = 0.05 }

            ];
         
        }
    }
}
