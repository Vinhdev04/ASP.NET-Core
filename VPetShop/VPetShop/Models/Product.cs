namespace VPetShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Made nullable
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public string? Description { get; set; } // Made nullable
        public string? ImagePath { get; set; } // Made nullable
        public int CategoryId { get; set; }
        public ProductDetails? Details { get; set; } // Already nullable
        public Category? Category { get; set; } // Already nullable
    }
}