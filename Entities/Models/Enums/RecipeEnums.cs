namespace Entities.Models.Enums
{
    public enum MealType
    {
        Breakfast,      // Kahvaltı
        Lunch,          // Öğle Yemeği
        Tea,            // Çay Saati
        Dinner,         // Akşam Yemeği
        Snack,          // Atıştırmalık
        Other           // Diğer
    }

    public enum DifficultyLevel
    {
        VeryEasy,       // Çok Kolay
        Easy,           // Kolay
        Moderate,       // Orta
        Intermediate,   // Orta Seviye
        Challenging,    // Zor
        Difficult,      // Çok Zor
        VeryDifficult,  // Uzman
        Expert          // Expert
    }

    public enum ServingSize
    {
        Small = 1,      // Küçük
        Medium = 2,     // Orta
        Large = 3,      // Büyük
        ExtraLarge = 4  // Çok Büyük
    }

    public enum Cuisine
    {
        Turkish,        // Türk
        Italian,        // İtalyan
        French,         // Fransız
        Chinese,        // Çin
        Indian,         // Hint
        Japanese,       // Japon
        Thai,           // Tay
        Mexican,        // Meksika
        Spanish,        // İspanyol
        Mediterranean,  // Akdeniz
        American,       // Amerikan
        Other           // Diğer
    }

    public enum Course
    {
        Appetizer,      // Aperatif
        Soup,           // Çorba
        Salad,          // Salata
        MainCourse,     // Ana Yemek
        SideDish,       // Yan Yemek
        Dessert,        // Tatlı
        Beverage,       // İçecek
        Other           // Diğer Yemekler
    }

}
