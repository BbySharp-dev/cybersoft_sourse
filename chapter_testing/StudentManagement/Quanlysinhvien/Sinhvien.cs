using System;
using System.Collections.Generic;
using System.Linq;

namespace Quanlysinhvien
{
    public class Sinhvien
    {
        private string sID;
        private string hoTen;
        private string khoa;
        private List<MonHoc> danhSachMon;

        public Sinhvien()
        {
            sID = "";
            hoTen = "";
            khoa = "";
            danhSachMon = new List<MonHoc>();
        }

        public Sinhvien(string id, string ten, string khoa)
        {
            this.sID = id;
            this.hoTen = ten;
            this.khoa = khoa;
            this.danhSachMon = new List<MonHoc>();
        }

        public string GetID() => sID;
        public string GetHoTen() => hoTen;
        public string GetKhoa() => khoa;
        public List<MonHoc> GetDanhSachMon() => danhSachMon;

        public void SetID(string id) => sID = id;
        public void SetHoTen(string ten) => hoTen = ten;
        public void SetKhoa(string khoa) => this.khoa = khoa;

        public int SetMon(string mon)
        {
            if (danhSachMon.Any(m => m.TenMon == mon)) return 0;
            danhSachMon.Add(new MonHoc(mon));
            return 1;
        }

        public int SetDiem(string mon, float diem)
        {
            var monHoc = danhSachMon.FirstOrDefault(m => m.TenMon == mon);
            if (monHoc == null) return 0;

            if (diem <= 4.5)
            {
                if (monHoc.SoLanThiLai >= 3) return 0;
                monHoc.SoLanThiLai++;
            }
            monHoc.Diem = diem;
            return 1;
        }

        public float TinhDTB()
        {
            if (danhSachMon.Count == 0) return 0;
            return danhSachMon.Average(m => m.Diem);
        }

        public float TinhDiemMax()
        {
            if (danhSachMon.Count == 0) return 0;
            return danhSachMon.Max(m => m.Diem);
        }

        public List<string> TenMonMax()
        {
            float maxDiem = TinhDiemMax();
            return danhSachMon.Where(m => m.Diem == maxDiem).Select(m => m.TenMon).ToList();
        }

        public List<string> TenMonThiLai()
        {
            return danhSachMon.Where(m => m.Diem <= 4.5).Select(m => m.TenMon).ToList();
        }

        public Dictionary<string, int> SoLanThiLai()
        {
            return danhSachMon.Where(m => m.SoLanThiLai > 0).ToDictionary(m => m.TenMon, m => m.SoLanThiLai);
        }

        public bool CheckChuyenNganh()
        {
            if (danhSachMon.Count < 10 || danhSachMon.Count(m => m.Diem >= 5) < 5)
                return false;

            var monCoSo = danhSachMon.Where(m => m.TenMon == "MonChuyenNganh" || m.TenMon == "ToanRoiRac" || m.TenMon == "TiengAnh").ToList();
            if (monCoSo.Count < 3 || monCoSo.Average(m => m.Diem) < 5)
                return false;

            return true;
        }
    }
}
