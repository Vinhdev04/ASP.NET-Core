using VPetShop.Models;

namespace VPetShop.Data
{
    public class MockRepository : IProductRepository, ICategoryRepository
    {
        private List<Product> _products = new List<Product>();
        private List<Category> _categories = new List<Category>();

        public MockRepository()
        {
            // Initialize mock categories
            _categories = new List<Category>
            {
                new Category { Id = 1, Name = "Chó" },
                new Category { Id = 2, Name = "Mèo" }
            };

            // Initialize mock products
            _products = new List<Product>
            {
                new Product
                {
                    Id = 1, Name = "Chó Poodle Trắng", NewPrice = 100m, OldPrice = 120m,
                    Description = "Poodle nhỏ nhắn, lông xoăn mềm mại, dễ huấn luyện, lý tưởng cho gia đình.",
                    ImagePath = "/images/poodle-01.jpg", CategoryId = 1,
                    Details = new ProductDetails { Origin = "Pháp", Weight = "4-6 kg", Temperament = "Thông minh, thân thiện", Health = "Đã tiêm phòng đầy đủ" }
                },
                new Product { Id = 2, Name = "Chó Poodle Vàng", NewPrice = 150m, OldPrice = 180m, Description = "Poodle năng động, lông vàng bóng, thích hợp làm bạn đồng hành.", ImagePath = "/images/poodle-02.jpg", CategoryId = 1, Details = new ProductDetails { Origin = "Pháp", Weight = "4-7 kg", Temperament = "Năng động", Health = "Khỏe mạnh" } },
                new Product { Id = 3, Name = "Mèo Ba Tư", NewPrice = 200m, OldPrice = 240m, Description = "Mèo Ba Tư lông dài, dịu dàng, thích hợp cho gia đình yêu thích sự nhẹ nhàng.", ImagePath = "/images/persian-01.jpg", CategoryId = 2, Details = new ProductDetails { Origin = "Iran", Weight = "3-5 kg", Temperament = "Dịu dàng", Health = "Đã tiêm phòng" } }
            };
        }

        // Explicit interface implementation for IProductRepository
        List<Product> IProductRepository.GetAll() => _products;
        Product IProductRepository.GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
        void IProductRepository.Add(Product product) => _products.Add(product);
        void IProductRepository.Update(Product product) { var existing = ((IProductRepository)this).GetById(product.Id); if (existing != null) _products[_products.IndexOf(existing)] = product; }
        void IProductRepository.Delete(int id) => _products.RemoveAll(p => p.Id == id);

        // Explicit interface implementation for ICategoryRepository
        List<Category> ICategoryRepository.GetAll() => _categories;
        Category ICategoryRepository.GetById(int id) => _categories.FirstOrDefault(c => c.Id == id);
        void ICategoryRepository.Add(Category category) => _categories.Add(category);
        void ICategoryRepository.Update(Category category) { var existing = ((ICategoryRepository)this).GetById(category.Id); if (existing != null) _categories[_categories.IndexOf(existing)] = category; }
        void ICategoryRepository.Delete(int id) => _categories.RemoveAll(c => c.Id == id);
    }
}