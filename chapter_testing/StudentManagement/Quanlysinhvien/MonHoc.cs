namespace Quanlysinhvien
{
    public class MonHoc
    {
        public string TenMon { get; set; }
        public float Diem { get; set; }
        public int SoLanThiLai { get; set; } = 0;

        public MonHoc(string tenMon)
        {
            TenMon = tenMon;
            Diem = 0;
        }
    }
}