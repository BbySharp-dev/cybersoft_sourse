using System.ComponentModel.DataAnnotations;

public class ContactFormModel
{
    [Required(ErrorMessage = "Họ và tên là bắt buộc.")]
    [MinLength(3, ErrorMessage = "Họ và tên phải có ít nhất 3 ký tự.")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email là bắt buộc.")]
    [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Số điện thoại phải từ 10-12 chữ số.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [MinLength(5, ErrorMessage = "Địa chỉ phải có ít nhất 5 ký tự.")]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Nội dung tin nhắn là bắt buộc.")]
    [MinLength(10, ErrorMessage = "Tin nhắn phải có ít nhất 10 ký tự.")]
    public string Message { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vui lòng chọn dịch vụ.")]
    public string SelectedService { get; set; } = string.Empty;

    [Required(ErrorMessage = "Bạn phải đồng ý với điều khoản và chính sách.")]
    public bool TermsAccepted { get; set; } = false;
}
