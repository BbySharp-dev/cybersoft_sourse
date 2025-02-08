using Quanlysinhvien;

namespace QuanlysinhvienTests
{
    [TestFixture]
    public class SinhvienTests
    {
        private Sinhvien _sinhVien;

        [SetUp]
        public void Setup()
        {
            _sinhVien = new Sinhvien("SV001", "Nguyen Van A", "CNTT");
        }


        [Test]
        public void SetMon_ValidSubject_Returns1()
        {
            int result = _sinhVien.SetMon("Lap Trinh C#");
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SetMon_DuplicateSubject_Returns0()
        {
            _sinhVien.SetMon("Lap Trinh C#");
            int result = _sinhVien.SetMon("Lap Trinh C#");
            Assert.That(result, Is.EqualTo(0));
        }


        [Test]
        public void SetDiem_ValidSubject_Returns1()
        {
            _sinhVien.SetMon("Lap Trinh C#");
            int result = _sinhVien.SetDiem("Lap Trinh C#", 8.5f);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SetDiem_SubjectNotFound_Returns0()
        {
            int result = _sinhVien.SetDiem("AI", 9.0f);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void SetDiem_BelowPassMark_IncreasesThiLaiCount()
        {
            _sinhVien.SetMon("Lap Trinh C#");
            _sinhVien.SetDiem("Lap Trinh C#", 3.5f);
            _sinhVien.SetDiem("Lap Trinh C#", 4.0f);
            _sinhVien.SetDiem("Lap Trinh C#", 4.5f);

            var monHoc = _sinhVien.GetDanhSachMon().Find(m => m.TenMon == "Lap Trinh C#");
            Assert.That(monHoc.SoLanThiLai, Is.EqualTo(3));
        }

        [Test]
        public void SetDiem_MaxThiLaiCount_Returns0()
        {
            _sinhVien.SetMon("Lap Trinh C#");
            _sinhVien.SetDiem("Lap Trinh C#", 3.5f);
            _sinhVien.SetDiem("Lap Trinh C#", 4.0f);
            _sinhVien.SetDiem("Lap Trinh C#", 4.5f);
            int result = _sinhVien.SetDiem("Lap Trinh C#", 4.2f); // Lần thi lại thứ 4 (nên không thể set)
            Assert.That(result, Is.EqualTo(0));
        }


        [Test]
        public void TinhDTB_ReturnsCorrectValue()
        {
            _sinhVien.SetMon("Lap Trinh C#");
            _sinhVien.SetDiem("Lap Trinh C#", 7.5f);
            _sinhVien.SetMon("Toan Roi Rac");
            _sinhVien.SetDiem("Toan Roi Rac", 8.0f);

            float result = _sinhVien.TinhDTB();
            Assert.That(result, Is.EqualTo(7.75f).Within(0.01f));
        }

        [Test]
        public void TinhDTB_NoSubjects_ReturnsZero()
        {
            float result = _sinhVien.TinhDTB();
            Assert.That(result, Is.EqualTo(0));
        }


        [Test]
        public void TinhDiemMax_ReturnsHighestScore()
        {
            _sinhVien.SetMon("Lap Trinh C#");
            _sinhVien.SetDiem("Lap Trinh C#", 7.5f);
            _sinhVien.SetMon("Toan Roi Rac");
            _sinhVien.SetDiem("Toan Roi Rac", 9.0f);

            float result = _sinhVien.TinhDiemMax();
            Assert.That(result, Is.EqualTo(9.0f));
        }


        [Test]
        public void TenMonMax_ReturnsSubjectsWithHighestScore()
        {
            _sinhVien.SetMon("Lap Trinh C#");
            _sinhVien.SetDiem("Lap Trinh C#", 9.0f);
            _sinhVien.SetMon("Toan Roi Rac");
            _sinhVien.SetDiem("Toan Roi Rac", 9.0f);
            _sinhVien.SetMon("AI");
            _sinhVien.SetDiem("AI", 8.0f);

            List<string> result = _sinhVien.TenMonMax();
            Assert.That(result, Is.EquivalentTo(new List<string> { "Lap Trinh C#", "Toan Roi Rac" }));
        }


        [Test]
        public void TenMonThiLai_ReturnsFailingSubjects()
        {
            _sinhVien.SetMon("Lap Trinh C#");
            _sinhVien.SetDiem("Lap Trinh C#", 3.0f);
            _sinhVien.SetMon("Toan Roi Rac");
            _sinhVien.SetDiem("Toan Roi Rac", 4.5f);
            _sinhVien.SetMon("AI");
            _sinhVien.SetDiem("AI", 6.0f);

            List<string> result = _sinhVien.TenMonThiLai();
            Assert.That(result, Is.EquivalentTo(new List<string> { "Lap Trinh C#", "Toan Roi Rac" }));
        }


        [Test]
        public void CheckChuyenNganh_NotEnoughSubjects_ReturnsFalse()
        {
            _sinhVien.SetMon("MonChuyenNganh");
            _sinhVien.SetDiem("MonChuyenNganh", 6.0f);
            bool result = _sinhVien.CheckChuyenNganh();
            Assert.That(result, Is.False);
        }

        [Test]
        public void CheckChuyenNganh_EnoughSubjectsButLowCoreSubject_ReturnsFalse()
        {
            _sinhVien.SetMon("MonChuyenNganh");
            _sinhVien.SetDiem("MonChuyenNganh", 4.0f); // Không đạt điểm yêu cầu

            _sinhVien.SetMon("Toan Roi Rac");
            _sinhVien.SetDiem("Toan Roi Rac", 6.0f);

            _sinhVien.SetMon("TiengAnh");
            _sinhVien.SetDiem("TiengAnh", 7.0f);

            _sinhVien.SetMon("AI");
            _sinhVien.SetDiem("AI", 8.0f);

            for (int i = 1; i <= 10; i++)
                _sinhVien.SetMon($"Mon_{i}");

            bool result = _sinhVien.CheckChuyenNganh();
            Assert.That(result, Is.False);
        }

        [Test]
        public void CheckChuyenNganh_ValidConditions_ReturnsTrue()
        {
            _sinhVien.SetMon("MonChuyenNganh");
            _sinhVien.SetDiem("MonChuyenNganh", 6.0f);

            _sinhVien.SetMon("Toan Roi Rac");
            _sinhVien.SetDiem("Toan Roi Rac", 6.0f);

            _sinhVien.SetMon("TiengAnh");
            _sinhVien.SetDiem("TiengAnh", 6.0f);

            for (int i = 1; i <= 10; i++)
                _sinhVien.SetMon($"Mon_{i}");

            bool result = _sinhVien.CheckChuyenNganh();
            Assert.That(result, Is.True);
        }
    }
}
