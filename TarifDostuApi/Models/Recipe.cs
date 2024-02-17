namespace TarifDostuApi.Models
{
    public class Recipe
    {
        public int Id { get; set; } // Tarifin benzersiz kimliği
        public string Name { get; set; } // Tarifin adı
        public string Description { get; set; } // Tarifin açıklaması
        public List<Ingredient> Ingredients { get; set; } // Tarifin malzemeleri listesi
        public string Instructions { get; set; } // Tarifin yapılış talimatları
        public string DifficultyLevel { get; set; } // Tarifin zorluk seviyesi
        public int ServingSize { get; set; } // Tarifin kaç kişilik olduğu
        public TimeSpan PreparationTime { get; set; } // Hazırlık süresi
        public TimeSpan CookingTime { get; set; } // Pişirme süresi
        public string Cuisine { get; set; } // Tarifin ait olduğu mutfak
        public string Course { get; set; } // Tarifin ait olduğu kurs
        public string MealType { get; set; } // Tarifin öğün tipi
        public List<string> Tags { get; set; } // Tarife ilişkilendirilmiş etiketler
        public string ImageUrl { get; set; } // Tarifin resim URL'si
        public bool IsVegetarian { get; set; } // Vejetaryen mi?
        public bool IsVegan { get; set; } // Vegan mı?
        public bool IsGlutenFree { get; set; } // Gluten içermiyor mu?
        public bool IsDairyFree { get; set; } // Süt ürünü içermiyor mu?
        public bool IsCustom { get; set; } // Özel bir tarif mi yoksa genel bir tarif mi olduğunu belirtir
        public List<Station> Stations { get; set; } // Tarifin gerektirdiği pişirme istasyonları listesi
    }

}
