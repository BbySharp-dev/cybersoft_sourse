using System;

public class ThanhToanBangThe : IThanhToan
{
    public bool ThanhToan(double soTien)
    {
        Console.Write("Nhập mã PIN để xác nhận giao dịch: ");
        string pin = Console.ReadLine();

        if (pin == "9999")
        {
            Console.WriteLine($"Thanh toán {soTien} VNĐ bằng thẻ thành công.");
            return true;
        }
        else
        {
            Console.WriteLine("Mã PIN không đúng. Thanh toán thất bại.");
            return false;
        }
    }
}
