using System;

public class SanPham
{
    public string MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public double GiaBan { get; set; }
    public int SoLuongTonKho { get; set; }

    public double TinhGiaTriTonKho()
    {
        return GiaBan * SoLuongTonKho;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Mã SP: {MaSanPham}, Tên: {TenSanPham}, Giá: {GiaBan}, Số lượng: {SoLuongTonKho}, Giá trị kho: {TinhGiaTriTonKho()}");
    }
}
