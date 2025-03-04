using System;

public class ThanhToanTienMat : IThanhToan
{
    public bool ThanhToan(double soTien)
    {
        Console.WriteLine($"Thanh toán {soTien} VNĐ bằng tiền mặt thành công.");
        return true;
    }
}
