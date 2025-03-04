using System;

class Program
{
    static void Main()
    {
        QuanLyHocSinh qlhs = new QuanLyHocSinh();
        int luaChon;

        do
        {
            Console.WriteLine("\n===== QUẢN LÝ HỌC SINH =====");
            Console.WriteLine("1. Thêm học sinh");
            Console.WriteLine("2. Tìm học sinh theo tên");
            Console.WriteLine("3. Cập nhật điểm học sinh");
            Console.WriteLine("4. Xóa học sinh");
            Console.WriteLine("5. Hiển thị danh sách học sinh");
            Console.WriteLine("6. Hiển thị danh sách theo điểm trung bình tăng dần");
            Console.WriteLine("7. Hiển thị danh sách theo tên");
            Console.WriteLine("8. Lưu danh sách vào file JSON");
            Console.WriteLine("9. Đọc danh sách từ file JSON");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1: qlhs.ThemHocSinh(); break;
                case 2: qlhs.TimKiemHocSinh(); break;
                case 3: qlhs.CapNhatDiem(); break;
                case 4: qlhs.XoaHocSinh(); break;
                case 5: qlhs.HienThiDanhSach(); break;
                case 6: qlhs.HienThiTheoDiemTB(); break;
                case 7: qlhs.HienThiTheoTen(); break;
                case 8: qlhs.LuuFileJson(); break;
                case 9: qlhs.DocFileJson(); break;
                case 0: Console.WriteLine("Thoát chương trình."); break;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
            }
        } while (luaChon != 0);
    }
}
