using System;

class Program
{
    static void Main()
    {
        LichSuGiaoDich lichSu = new LichSuGiaoDich();
        int luaChon;

        do
        {
            Console.WriteLine("\n===== HỆ THỐNG THANH TOÁN =====");
            Console.WriteLine("1. Thanh toán bằng tiền mặt");
            Console.WriteLine("2. Thanh toán bằng thẻ");
            Console.WriteLine("3. Thanh toán online");
            Console.WriteLine("4. Xem lịch sử giao dịch");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine());

            IThanhToan phuongThucThanhToan = null;
            string phuongThuc = "";
            double soTien = 0;

            if (luaChon >= 1 && luaChon <= 3)
            {
                Console.Write("Nhập số tiền cần thanh toán: ");
                soTien = double.Parse(Console.ReadLine());
            }

            switch (luaChon)
            {
                case 1:
                    phuongThucThanhToan = new ThanhToanTienMat();
                    phuongThuc = "Tiền mặt";
                    break;
                case 2:
                    phuongThucThanhToan = new ThanhToanBangThe();
                    phuongThuc = "Thẻ";
                    break;
                case 3:
                    phuongThucThanhToan = new ThanhToanOnline();
                    phuongThuc = "Online";
                    break;
                case 4:
                    lichSu.HienThiLichSu();
                    continue;
                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    continue;
            }

            if (phuongThucThanhToan != null)
            {
                bool thanhCong = phuongThucThanhToan.ThanhToan(soTien);
                if (thanhCong)
                {
                    string giaoDich = $"Giao dịch {phuongThuc}: {soTien} VNĐ - Thành công";
                    lichSu.LuuGiaoDich(giaoDich);
                }
            }

        } while (luaChon != 0);
    }
}
