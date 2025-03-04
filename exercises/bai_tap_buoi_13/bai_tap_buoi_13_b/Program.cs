using System;

class Program
{
    static void Main()
    {
        QuanLySanPham qlsp = new QuanLySanPham();
        QuanLyDonHang qldh = new QuanLyDonHang();
        int luaChon;

        do
        {
            Console.WriteLine("\n===== QUẢN LÝ SẢN PHẨM - ĐƠN HÀNG =====");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Tìm sản phẩm theo tên");
            Console.WriteLine("3. Cập nhật sản phẩm");
            Console.WriteLine("4. Xóa sản phẩm");
            Console.WriteLine("5. Hiển thị danh sách sản phẩm");
            Console.WriteLine("6. Thêm đơn hàng");
            Console.WriteLine("7. Cập nhật trạng thái đơn hàng");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1: qlsp.ThemSanPham(); break;
                case 2: qlsp.TimKiemSanPham(); break;
                case 3: qlsp.CapNhatSanPham(); break;
                case 4: qlsp.XoaSanPham(); break;
                case 5: qlsp.HienThiDanhSach(); break;
                case 6: qldh.ThemDonHang(); break;
                case 7: qldh.CapNhatTrangThaiGiaoHang(); break;
                case 0: Console.WriteLine("Thoát chương trình."); break;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
            }
        } while (luaChon != 0);
    }
}
