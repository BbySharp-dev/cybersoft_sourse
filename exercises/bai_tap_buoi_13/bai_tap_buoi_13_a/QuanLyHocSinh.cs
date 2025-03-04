using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

public class QuanLyHocSinh
{
    private List<HocSinh> danhSachHocSinh = new List<HocSinh>();

    public void ThemHocSinh()
    {
        Console.Write("Nhập mã học sinh: ");
        string maHS = Console.ReadLine();
        Console.Write("Nhập tên học sinh: ");
        string tenHS = Console.ReadLine();
        Console.Write("Nhập điểm Toán: ");
        double diemToan = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Văn: ");
        double diemVan = double.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Anh: ");
        double diemAnh = double.Parse(Console.ReadLine());

        danhSachHocSinh.Add(new HocSinh { MaHocSinh = maHS, TenHocSinh = tenHS, DiemToan = diemToan, DiemVan = diemVan, DiemAnh = diemAnh });
        Console.WriteLine("Đã thêm học sinh!");
    }

    public void TimKiemHocSinh()
    {
        Console.Write("Nhập tên học sinh cần tìm: ");
        string ten = Console.ReadLine();
        var ketQua = danhSachHocSinh.Where(hs => hs.TenHocSinh.Contains(ten, StringComparison.OrdinalIgnoreCase)).ToList();

        if (ketQua.Count == 0)
        {
            Console.WriteLine("Không tìm thấy học sinh!");
        }
        else
        {
            foreach (var hs in ketQua)
            {
                hs.HienThiThongTin();
            }
        }
    }

    public void CapNhatDiem()
    {
        Console.Write("Nhập mã học sinh cần cập nhật: ");
        string maHS = Console.ReadLine();
        var hs = danhSachHocSinh.FirstOrDefault(h => h.MaHocSinh == maHS);

        if (hs != null)
        {
            Console.Write("Nhập điểm Toán mới: ");
            hs.DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Văn mới: ");
            hs.DiemVan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Anh mới: ");
            hs.DiemAnh = double.Parse(Console.ReadLine());
            Console.WriteLine("Cập nhật điểm thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy học sinh!");
        }
    }

    public void XoaHocSinh()
    {
        Console.Write("Nhập mã học sinh cần xóa: ");
        string maHS = Console.ReadLine();
        var hs = danhSachHocSinh.FirstOrDefault(h => h.MaHocSinh == maHS);

        if (hs != null)
        {
            danhSachHocSinh.Remove(hs);
            Console.WriteLine("Xóa thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy học sinh!");
        }
    }

    public void HienThiDanhSach()
    {
        Console.WriteLine("Danh sách học sinh:");
        foreach (var hs in danhSachHocSinh)
        {
            hs.HienThiThongTin();
        }
    }

    public void HienThiTheoDiemTB()
    {
        var dsSapXep = danhSachHocSinh.OrderBy(hs => hs.TinhDTB()).ToList();
        foreach (var hs in dsSapXep)
        {
            hs.HienThiThongTin();
        }
    }

    public void HienThiTheoTen()
    {
        var dsSapXep = danhSachHocSinh.OrderBy(hs => hs.TenHocSinh.Split(" ").Last()).ToList();
        foreach (var hs in dsSapXep)
        {
            hs.HienThiThongTin();
        }
    }

    public void LuuFileJson()
    {
        File.WriteAllText("danhSachHocSinh.json", JsonConvert.SerializeObject(danhSachHocSinh, Formatting.Indented));
        Console.WriteLine("Đã lưu danh sách học sinh vào file JSON!");
    }

    public void DocFileJson()
    {
        if (File.Exists("danhSachHocSinh.json"))
        {
            danhSachHocSinh = JsonConvert.DeserializeObject<List<HocSinh>>(File.ReadAllText("danhSachHocSinh.json"));
            Console.WriteLine("Đã tải danh sách học sinh từ file JSON!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy file JSON!");
        }
    }
}
