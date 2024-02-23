using Entities.Models.Enums;
namespace Entities.Models
{
    public class StockLog
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int QuantityChanged { get; set; }
        public DateTime DateChanged { get; set; }
        public StockAction  Action { get; set; } // Alım, Satım, Güncelleme vb.
    }
}
