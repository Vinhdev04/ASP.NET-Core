using System.ComponentModel.DataAnnotations;

namespace VPetShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc")]
        [StringLength(100, ErrorMessage = "Tên sản phẩm không được vượt quá 100 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giá mới là bắt buộc")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá mới phải lớn hơn 0")]
        public decimal NewPrice { get; set; }

        [Required(ErrorMessage = "Giá cũ là bắt buộc")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá cũ phải lớn hơn 0")]
        public decimal OldPrice { get; set; }

        [Required(ErrorMessage = "Mô tả là bắt buộc")]
        [StringLength(500, ErrorMessage = "Mô tả không được vượt quá 500 ký tự")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Đường dẫn hình ảnh là bắt buộc")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Danh mục là bắt buộc")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ProductDetails Details { get; set; }
    }

    public class ProductDetails
    {
        public string Origin { get; set; }
        public string Weight { get; set; }
        public string Temperament { get; set; }
        public string Health { get; set; }
    }
}