using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

public class QuanLySanPham
{
    private List<SanPham> danhSachSanPham = new List<SanPham>();

    public void ThemSanPham()
    {
        Console.Write("Nhập mã sản phẩm: ");
        string maSP = Console.ReadLine();
        Console.Write("Nhập tên sản phẩm: ");
        string tenSP = Console.ReadLine();
        Console.Write("Nhập giá bán: ");
        double giaBan = double.Parse(Console.ReadLine());
        Console.Write("Nhập số lượng tồn kho: ");
        int soLuong = int.Parse(Console.ReadLine());

        danhSachSanPham.Add(new SanPham { MaSanPham = maSP, TenSanPham = tenSP, GiaBan = giaBan, SoLuongTonKho = soLuong });
        Console.WriteLine("Đã thêm sản phẩm!");
    }

    public void TimKiemSanPham()
    {
        Console.Write("Nhập tên sản phẩm cần tìm: ");
        string ten = Console.ReadLine();
        var ketQua = danhSachSanPham.Where(sp => sp.TenSanPham.Contains(ten, StringComparison.OrdinalIgnoreCase)).ToList();

        if (ketQua.Count == 0)
        {
            Console.WriteLine("Không tìm thấy sản phẩm!");
        }
        else
        {
            foreach (var sp in ketQua)
            {
                sp.HienThiThongTin();
            }
        }
    }

    public void CapNhatSanPham()
    {
        Console.Write("Nhập mã sản phẩm cần cập nhật: ");
        string maSP = Console.ReadLine();
        var sp = danhSachSanPham.FirstOrDefault(p => p.MaSanPham == maSP);

        if (sp != null)
        {
            Console.Write("Nhập giá bán mới: ");
            sp.GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng tồn kho mới: ");
            sp.SoLuongTonKho = int.Parse(Console.ReadLine());
            Console.WriteLine("Cập nhật thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm!");
        }
    }

    public void XoaSanPham()
    {
        Console.Write("Nhập mã sản phẩm cần xóa: ");
        string maSP = Console.ReadLine();
        var sp = danhSachSanPham.FirstOrDefault(p => p.MaSanPham == maSP);

        if (sp != null)
        {
            danhSachSanPham.Remove(sp);
            Console.WriteLine("Xóa thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm!");
        }
    }

    public void HienThiDanhSach()
    {
        Console.WriteLine("Danh sách sản phẩm:");
        foreach (var sp in danhSachSanPham)
        {
            sp.HienThiThongTin();
        }
    }

    public void SapXepTheoGia()
    {
        var dsSapXep = danhSachSanPham.OrderBy(sp => sp.GiaBan).ToList();
        foreach (var sp in dsSapXep)
        {
            sp.HienThiThongTin();
        }
    }

    public void SapXepTheoTen()
    {
        var dsSapXep = danhSachSanPham.OrderBy(sp => sp.TenSanPham.Split(" ").Last()).ToList();
        foreach (var sp in dsSapXep)
        {
            sp.HienThiThongTin();
        }
    }

    public void LuuFileJson()
    {
        File.WriteAllText("sanpham.json", JsonConvert.SerializeObject(danhSachSanPham, Formatting.Indented));
        Console.WriteLine("Đã lưu danh sách sản phẩm vào file JSON!");
    }

    public void DocFileJson()
    {
        if (File.Exists("sanpham.json"))
        {
            danhSachSanPham = JsonConvert.DeserializeObject<List<SanPham>>(File.ReadAllText("sanpham.json"));
            Console.WriteLine("Đã tải danh sách sản phẩm từ file JSON!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy file JSON!");
        }
    }
}
