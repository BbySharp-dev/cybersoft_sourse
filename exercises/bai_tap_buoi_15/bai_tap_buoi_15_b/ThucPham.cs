using System;

public class ThucPham : SanPham
{
    public double PhiVanChuyen { get; set; }

    public override double TinhGiaBan()
    {
        return GiaGoc + PhiVanChuyen;
    }

    public override void HienThiThongTin()
    {
        Console.WriteLine($"Mã SP: {MaSanPham}, Tên: {TenSanPham}, Giá bán: {TinhGiaBan()} VNĐ (Đã bao gồm phí vận chuyển {PhiVanChuyen} VNĐ)");
    }
}
