using System.ComponentModel.DataAnnotations;

namespace VPetShop.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Họ và Tên là bắt buộc")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Tin nhắn là bắt buộc")]
        public string Message { get; set; }
    }
}
