namespace TarifDostuApi.Models.Enums
{
    public enum IngredientType
    {
        Vegetable,          // Sebze
        Meat,               // Et
        Protein,            // Protein
        Oil,                // Yağ
        Grain,              // Tahıl
        Legume,             // Baklagil
        DairyProduct,       // Süt Ürünü
        Fruit,              // Meyve
        Seafood,            // Deniz Ürünü
        BakeryProduct,      // Fırın Ürünü
        Nut,                // Fındık/Fıstık
        Beverage            // İçecek
    }

    public enum UnitType
    {
        Piece,              // Adet
        Gram,               // Gram
        Milliliter,         // Mililitre
        Clove,              // Diş
        Bunch               // Demet
    }
    public enum StockAction{
        Usage, // Kullanım
        Purchase, // Alım
        Sale, // Satış
        Adjustment, // Düzeltme
        Return, // İade
        TransferIn, // Transfer Girişi
        TransferOut, // Transfer Çıkışı
        Waste, // Atık
        Spoilage, // Bozulma
        Production, // Üretim
        Other // Diğer
    }
}
