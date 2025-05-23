using VPetShop.Models;

namespace VPetShop.Data
{
    public class MockRepository : IProductRepository, ICategoryRepository
    {
        private List<Product> _products = new List<Product>();
        private List<Category> _categories = new List<Category>();

        public MockRepository()
        {
            _categories = MockPetData.GetCategories();
            _products = MockPetData.GetPets();
        }

        // IProductRepository implementation
        List<Product> IProductRepository.GetAll() => _products;
        Product IProductRepository.GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
        void IProductRepository.Add(Product product) => _products.Add(product);
        void IProductRepository.Update(Product product)
        {
            var existing = ((IProductRepository)this).GetById(product.Id);
            if (existing != null) _products[_products.IndexOf(existing)] = product;
        }
        void IProductRepository.Delete(int id) => _products.RemoveAll(p => p.Id == id);

        // ICategoryRepository implementation
        List<Category> ICategoryRepository.GetAll() => _categories;
        Category ICategoryRepository.GetById(int id) => _categories.FirstOrDefault(c => c.Id == id);
        void ICategoryRepository.Add(Category category) => _categories.Add(category);
        void ICategoryRepository.Update(Category category)
        {
            var existing = ((ICategoryRepository)this).GetById(category.Id);
            if (existing != null) _categories[_categories.IndexOf(existing)] = category;
        }
        void ICategoryRepository.Delete(int id) => _categories.RemoveAll(c => c.Id == id);
    }
}