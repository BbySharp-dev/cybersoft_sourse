using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

public class QuanLyDonHang
{
    private List<DonHang> danhSachDonHang = new List<DonHang>();

    public void ThemDonHang()
    {
        Console.Write("Nhập mã đơn hàng: ");
        string maDH = Console.ReadLine();
        Console.Write("Nhập mã sản phẩm: ");
        string maSP = Console.ReadLine();
        Console.Write("Nhập số lượng bán: ");
        int soLuong = int.Parse(Console.ReadLine());
        Console.Write("Nhập tên người đặt: ");
        string tenNguoiDat = Console.ReadLine();

        danhSachDonHang.Add(new DonHang { MaDonHang = maDH, MaSanPham = maSP, SoLuongBan = soLuong, TenNguoiDat = tenNguoiDat, DaGiaoHang = false });
        Console.WriteLine("Đã thêm đơn hàng!");
    }

    public void CapNhatTrangThaiGiaoHang()
    {
        Console.Write("Nhập mã đơn hàng cần cập nhật: ");
        string maDH = Console.ReadLine();
        var dh = danhSachDonHang.FirstOrDefault(d => d.MaDonHang == maDH);

        if (dh != null)
        {
            dh.DaGiaoHang = true;
            Console.WriteLine("Cập nhật trạng thái giao hàng thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy đơn hàng!");
        }
    }
}
