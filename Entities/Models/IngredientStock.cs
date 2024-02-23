namespace Entities.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public Double Quantity { get; set; }
        public DateTime LastUpdated { get; set; }
       
    }
}
