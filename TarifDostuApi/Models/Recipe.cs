using TarifDostuApi.Models.Enums;

namespace TarifDostuApi.Models
{
    public class Recipe
    {
        public int Id { get; set; } // Tarifin benzersiz kimliği
        public string Name { get; set; } // Tarifin adı
        public string ShortDescription { get; set; } // Tarifin açıklaması
        public string BodyDescription { get; set; } // Tarifin açıklaması
        public string Instructions { get; set; } // Tarifin yapılış talimatları
        public TimeSpan PreparationTime { get; set; } // Hazırlık süresi
        public TimeSpan CookingTime { get; set; } // Pişirme süresi
        public List<Ingredient> Ingredients { get; set; } // Tarifin malzemeleri listesi
        public List<RecipePropeties> Properties { get; set; } // Tarifin özelikleri RecipeProperties modeline bağlı veritabanında JSON olarak tutacak.
        public List<string> Tags { get; set; } // Tarife ilişkilendirilmiş etiketler

        public List<Station> Stations { get; set; } // Tarifin gerektirdiği pişirme istasyonları listesi
    }

    public class RecipePropeties
    {
        public List<MealType> MealType { get; set; } // Tarifin öğün tipi
        public DifficultyLevel DifficultyLevel { get; set; } // Tarifin zorluk seviyesi
        public List<ServingSize> ServingSize { get; set; } // Tarifin kaç kişilik olduğu
        public List<Cuisine> Cuisine { get; set; } // Tarifin ait olduğu mutfak
        public List<Course> Course { get; set; } // Tarifin ait olduğu kurs
        public bool IsSpicy { get; set; } // Baharatlı mı?
        public bool IsHealthy { get; set; } // Sağlıklı mı ?
        public bool IsQuick { get; set; } // Hızlı mı?
        public bool IsVegan { get; set; } // Vegan mı?
        public bool IsGlutenFree { get; set; } // Gluten içermiyor mu?
        public bool IsDairyFree { get; set; } // Süt ürünü içermiyor mu?
        public bool IsVegetarian { get; set; } // Vejetaryen mi?
        public bool IsCustom { get; set; } // Özel bir tarif mi yoksa genel bir tarif mi olduğunu belirtir
        public string MainImageUrl { get; set; } // Tarifin Ön resim URL'si
        public List<string> ImageUrls { get; set; } // Tarifin resim URL'leri
        public List<string> VideoUrls { get; set; } // Tarifin video URL'leri
    }

}
