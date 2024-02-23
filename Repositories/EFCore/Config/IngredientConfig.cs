using Entities.Models;
using Entities.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class IngredientConfig : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasData(
                    
           new Ingredient { Id = 1, Name = "Tomato", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 0.5 },
                    new Ingredient { Id = 2, Name = "Onion", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 0.3 },
                    new Ingredient { Id = 3, Name = "Chicken Breast", Type = IngredientType.Meat, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 9.99 },
                    new Ingredient { Id = 4, Name = "Egg", Type = IngredientType.Protein, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 0.2 },
                    new Ingredient { Id = 5, Name = "Garlic", Type = IngredientType.Vegetable, Unit = UnitType.Clove, IsCustom = false, EstimatedUnitPrice = 0.1 },
                    new Ingredient { Id = 6, Name = "Olive Oil", Type = IngredientType.Oil, Unit = UnitType.Milliliter, IsCustom = false, EstimatedUnitPrice = 0.15 },
                    new Ingredient { Id = 7, Name = "Red Pepper", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 0.75 },
                    new Ingredient { Id = 8, Name = "Rice", Type = IngredientType.Grain, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.05 },
                    new Ingredient { Id = 9, Name = "Chicken Leg", Type = IngredientType.Meat, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 8.5 },
                    new Ingredient { Id = 10, Name = "Parsley", Type = IngredientType.Vegetable, Unit = UnitType.Bunch, IsCustom = false, EstimatedUnitPrice = 0.5 },
                    new Ingredient { Id = 11, Name = "Lentils", Type = IngredientType.Legume, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.1 },
                    new Ingredient { Id = 12, Name = "Cheddar Cheese", Type = IngredientType.DairyProduct, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.3 },
                    new Ingredient { Id = 13, Name = "Ground Beef", Type = IngredientType.Meat, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 10.99 },
                    new Ingredient { Id = 14, Name = "Potato", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 0.25 },
                    new Ingredient { Id = 15, Name = "Flour", Type = IngredientType.BakeryProduct, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.03 },
                    new Ingredient { Id = 16, Name = "Yogurt", Type = IngredientType.DairyProduct, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.15 },
                    new Ingredient { Id = 17, Name = "Lemon", Type = IngredientType.Fruit, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 0.5 },
                    new Ingredient { Id = 18, Name = "Broccoli", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 1.0 },
                    new Ingredient { Id = 19, Name = "Milk", Type = IngredientType.DairyProduct, Unit = UnitType.Milliliter, IsCustom = false, EstimatedUnitPrice = 0.2 },
                    new Ingredient { Id = 20, Name = "Fish", Type = IngredientType.Seafood, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 15.99 },
                    new Ingredient { Id = 21, Name = "Butter", Type = IngredientType.Oil, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.2 },
                    new Ingredient { Id = 22, Name = "Basil", Type = IngredientType.Vegetable, Unit = UnitType.Bunch, IsCustom = false, EstimatedUnitPrice = 1.0 },
                    new Ingredient { Id = 23, Name = "Cheddar Cheese", Type = IngredientType.DairyProduct, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.4 },
                    new Ingredient { Id = 24, Name = "Asparagus", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 3.0 },
                    new Ingredient { Id = 25, Name = "Red Cabbage", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 1.5 },
                    new Ingredient { Id = 26, Name = "Leek", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 0.75 },
                    new Ingredient { Id = 27, Name = "Hazelnut", Type = IngredientType.Nut, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.5 },
                    new Ingredient { Id = 28, Name = "Zucchini", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 0.75 },
                    new Ingredient { Id = 29, Name = "Grapes", Type = IngredientType.Fruit, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.6 },
                    new Ingredient { Id = 30, Name = "Almond", Type = IngredientType.Nut, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 1.0 },
                    new Ingredient { Id = 31, Name = "Red Lentils", Type = IngredientType.Legume, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.2 },
                    new Ingredient { Id = 32, Name = "Beans", Type = IngredientType.Legume, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.3 },
                    new Ingredient { Id = 33, Name = "Chestnut", Type = IngredientType.Nut, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 2.0 },
                    new Ingredient { Id = 34, Name = "Apple", Type = IngredientType.Fruit, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 0.8 },
                    new Ingredient { Id = 35, Name = "Mushroom", Type = IngredientType.Vegetable, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.6 },
                    new Ingredient { Id = 36, Name = "Cauliflower", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 2.0 },
                    new Ingredient { Id = 37, Name = "Strawberry", Type = IngredientType.Fruit, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 1.2 },
                    new Ingredient { Id = 38, Name = "Dried Plum", Type = IngredientType.Fruit, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.4 },
                    new Ingredient { Id = 39, Name = "Bread", Type = IngredientType.BakeryProduct, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.05 },
                    new Ingredient { Id = 40, Name = "Red Cabbage", Type = IngredientType.Vegetable, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 1.5 },
                    new Ingredient { Id = 41, Name = "Hazelnut", Type = IngredientType.Nut, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.5 },
                    new Ingredient { Id = 42, Name = "Pumpkin Seeds", Type = IngredientType.Nut, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.6 },
                    new Ingredient { Id = 43, Name = "Lemon", Type = IngredientType.Fruit, Unit = UnitType.Piece, IsCustom = false, EstimatedUnitPrice = 0.5 },
                    new Ingredient { Id = 44, Name = "Garlic", Type = IngredientType.Vegetable, Unit = UnitType.Clove, IsCustom = false, EstimatedUnitPrice = 0.1 },
                    new Ingredient { Id = 45, Name = "Basil", Type = IngredientType.Vegetable, Unit = UnitType.Bunch, IsCustom = false, EstimatedUnitPrice = 1.0 },
                    new Ingredient { Id = 46, Name = "Olive", Type = IngredientType.Fruit, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.7 },
                    new Ingredient { Id = 47, Name = "Rice", Type = IngredientType.Grain, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.1 },
                    new Ingredient { Id = 48, Name = "Kidney Beans", Type = IngredientType.Legume, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.2 },
                    new Ingredient { Id = 49, Name = "Coffee", Type = IngredientType.Beverage, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.1 },
                    new Ingredient { Id = 50, Name = "Tea", Type = IngredientType.Beverage, Unit = UnitType.Gram, IsCustom = false, EstimatedUnitPrice = 0.05 }

                );
        }
    }
}
