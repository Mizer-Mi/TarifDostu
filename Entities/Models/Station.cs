namespace Entities.Models
{
    public class Station
    {
        public int Id { get; set; } // id
        public string Name { get; set; } // Adı
        public string Description { get; set; } // Açıklaması
        public int Capacity { get; set; } // İstasyonun kapasitesi
        public string PowerConsumption { get; set; } // İstasyonun güç tüketimi
        public bool IsPortable { get; set; } // Taşınabilir mi?
        public List<string> SpecialFeatures { get; set; } // İstasyonun özel özellikleri (örneğin: ısıtma fonksiyonu, otomatik programlar vs.)
    }
}
