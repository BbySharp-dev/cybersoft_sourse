using System;
using System.ComponentModel.DataAnnotations;

public class CourseRegistrationModel
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

    [Required(ErrorMessage = "Vui lòng chọn khóa học.")]
    public string SelectedCourse { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vui lòng chọn hình thức học.")]
    public string StudyMode { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vui lòng chọn ngày bắt đầu.")]
    public DateTime PreferredStartDate { get; set; }

    public string Comments { get; set; } = string.Empty;

    [Required(ErrorMessage = "Bạn phải đồng ý với điều khoản.")]
    public bool TermsAccepted { get; set; } = false;
}
