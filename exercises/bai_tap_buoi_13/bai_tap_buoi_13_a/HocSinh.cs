using System;

public class HocSinh
{
    public string MaHocSinh { get; set; }
    public string TenHocSinh { get; set; }
    public double DiemToan { get; set; }
    public double DiemVan { get; set; }
    public double DiemAnh { get; set; }

    public double TinhDTB()
    {
        return (DiemToan + DiemVan + DiemAnh) / 3.0;
    }

    public string XepLoai()
    {
        double dtb = TinhDTB();
        if (dtb < 5) return "Yếu";
        if (dtb < 6.5) return "Trung bình";
        if (dtb < 8) return "Khá";
        return "Giỏi";
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Mã HS: {MaHocSinh}, Tên: {TenHocSinh}, ĐTB: {TinhDTB():0.##}, Xếp loại: {XepLoai()}");
    }
}
