using System;

public class ThoiTrang : SanPham
{
    public double GiamGia { get; set; }

    public override double TinhGiaBan()
    {
        return GiaGoc - (GiaGoc * GiamGia / 100);
    }

    public override void HienThiThongTin()
    {
        Console.WriteLine($"Mã SP: {MaSanPham}, Tên: {TenSanPham}, Giá bán: {TinhGiaBan()} VNĐ (Đã giảm giá {GiamGia}%)");
    }
}
