using System;

public class DienTu : SanPham
{
    public double ThueBaoHanh { get; set; }

    public override double TinhGiaBan()
    {
        return GiaGoc + (GiaGoc * ThueBaoHanh / 100);
    }

    public override void HienThiThongTin()
    {
        Console.WriteLine($"Mã SP: {MaSanPham}, Tên: {TenSanPham}, Giá bán: {TinhGiaBan()} VNĐ (Đã bao gồm thuế bảo hành {ThueBaoHanh}%)");
    }
}
