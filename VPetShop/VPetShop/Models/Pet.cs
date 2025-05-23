namespace VPetShop.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public PetDetails Details { get; set; }
    }

    public class PetDetails
    {
        public string Origin { get; set; }
        public string Weight { get; set; }
        public string Temperament { get; set; }
        public string Health { get; set; }
    }
}
