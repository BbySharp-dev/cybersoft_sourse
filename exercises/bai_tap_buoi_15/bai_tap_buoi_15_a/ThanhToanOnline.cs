using System;

public class ThanhToanOnline : IThanhToan
{
    public bool ThanhToan(double soTien)
    {
        Console.Write("Nhập mã OTP để xác nhận giao dịch: ");
        string otp = Console.ReadLine();

        if (otp == "1234")
        {
            Console.WriteLine($"Thanh toán {soTien} VNĐ online thành công.");
            return true;
        }
        else
        {
            Console.WriteLine("Mã OTP không đúng. Thanh toán thất bại.");
            return false;
        }
    }
}
