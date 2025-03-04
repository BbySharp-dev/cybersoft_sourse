using System;

public class DonHang
{
    public string MaDonHang { get; set; }
    public string MaSanPham { get; set; }
    public int SoLuongBan { get; set; }
    public string TenNguoiDat { get; set; }
    public bool DaGiaoHang { get; set; }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Mã ĐH: {MaDonHang}, Mã SP: {MaSanPham}, Số lượng: {SoLuongBan}, Người đặt: {TenNguoiDat}, Giao hàng: {(DaGiaoHang ? "Đã giao" : "Chưa giao")}");
    }
}
