using System;
using System.Collections.Generic;
using System.Linq;

public class QuanLySanPham
{
    private List<SanPham> danhSachSanPham = new List<SanPham>();

    public void ThemSanPham()
    {
        Console.WriteLine("Chọn loại sản phẩm:");
        Console.WriteLine("1. Điện tử");
        Console.WriteLine("2. Thời trang");
        Console.WriteLine("3. Thực phẩm");
        int loai = int.Parse(Console.ReadLine());

        Console.Write("Nhập mã sản phẩm: ");
        string maSP = Console.ReadLine();
        Console.Write("Nhập tên sản phẩm: ");
        string tenSP = Console.ReadLine();
        Console.Write("Nhập giá gốc: ");
        double giaGoc = double.Parse(Console.ReadLine());

        SanPham sp = null;

        switch (loai)
        {
            case 1:
                Console.Write("Nhập thuế bảo hành (%): ");
                double thue = double.Parse(Console.ReadLine());
                sp = new DienTu { MaSanPham = maSP, TenSanPham = tenSP, GiaGoc = giaGoc, ThueBaoHanh = thue };
                break;
            case 2:
                Console.Write("Nhập mức giảm giá (%): ");
                double giamGia = double.Parse(Console.ReadLine());
                sp = new ThoiTrang { MaSanPham = maSP, TenSanPham = tenSP, GiaGoc = giaGoc, GiamGia = giamGia };
                break;
            case 3:
                Console.Write("Nhập phí vận chuyển: ");
                double phiVanChuyen = double.Parse(Console.ReadLine());
                sp = new ThucPham { MaSanPham = maSP, TenSanPham = tenSP, GiaGoc = giaGoc, PhiVanChuyen = phiVanChuyen };
                break;
            default:
                Console.WriteLine("Loại sản phẩm không hợp lệ!");
                return;
        }

        danhSachSanPham.Add(sp);
        Console.WriteLine("Đã thêm sản phẩm!");
    }

    public void HienThiDanhSachSanPham()
    {
        Console.WriteLine("\n===== DANH SÁCH SẢN PHẨM =====");
        foreach (var sp in danhSachSanPham)
        {
            sp.HienThiThongTin();
        }
    }

    public void TinhTongDoanhThu()
    {
        double tongDoanhThu = danhSachSanPham.Sum(sp => sp.TinhGiaBan());
        Console.WriteLine($"\nTổng doanh thu dự kiến: {tongDoanhThu} VNĐ");
    }

    public void XoaSanPham()
    {
        Console.Write("Nhập mã sản phẩm cần xóa: ");
        string maSP = Console.ReadLine();
        var sp = danhSachSanPham.FirstOrDefault(p => p.MaSanPham == maSP);

        if (sp != null)
        {
            danhSachSanPham.Remove(sp);
            Console.WriteLine("Xóa sản phẩm thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm!");
        }
    }
}
