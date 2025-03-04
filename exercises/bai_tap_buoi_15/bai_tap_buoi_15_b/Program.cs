using System;

class Program
{
    static void Main()
    {
        QuanLySanPham qlsp = new QuanLySanPham();
        int luaChon;

        do
        {
            Console.WriteLine("\n===== HỆ THỐNG QUẢN LÝ BÁN HÀNG =====");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính tổng doanh thu");
            Console.WriteLine("4. Xóa sản phẩm");
            Console.WriteLine("5. Thoát");
            Console.Write("Vui lòng chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1: qlsp.ThemSanPham(); break;
                case 2: qlsp.HienThiDanhSachSanPham(); break;
                case 3: qlsp.TinhTongDoanhThu(); break;
                case 4: qlsp.XoaSanPham(); break;
                case 5: Console.WriteLine("Thoát chương trình."); break;
                default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
            }
        } while (luaChon != 5);
    }
}
