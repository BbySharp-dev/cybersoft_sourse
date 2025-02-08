using CalculatorLibrary;
namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        // Setup trước khi chạy mỗi test case
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        //  VALID TEST CASES (Hợp lệ) 

        //  Kiểm tra phép cộng với số nguyên
        [Test]
        public void Add_Int_ReturnsCorrectSum()
        {
            Assert.That(_calculator.Add(2, 3), Is.EqualTo(5));
        }

        //  Kiểm tra phép cộng với số thực
        [Test]
        public void Add_Float_ReturnsCorrectSum()
        {
            Assert.That(_calculator.Add(2.5f, 3.5f), Is.EqualTo(6.0f));
        }

        //  Kiểm tra phép trừ với số nguyên
        [Test]
        public void Subtract_Int_ReturnsCorrectResult()
        {
            Assert.That(_calculator.Subtract(10, 4), Is.EqualTo(6));
        }

        //  Kiểm tra phép trừ với số thực
        [Test]
        public void Subtract_Float_ReturnsCorrectResult()
        {
            Assert.That(_calculator.Subtract(10.5f, 4.2f), Is.EqualTo(6.3f).Within(0.0001f));
        }

        //  Kiểm tra phép nhân với số nguyên
        [Test]
        public void Multiply_Int_ReturnsCorrectResult()
        {
            Assert.That(_calculator.Multiply(6, 3), Is.EqualTo(18));
        }

        //  Kiểm tra phép nhân với số thực
        [Test]
        public void Multiply_Float_ReturnsCorrectResult()
        {
            Assert.That(_calculator.Multiply(2.5f, 4.0f), Is.EqualTo(10.0f));
        }

        //  Kiểm tra phép chia với số nguyên
        [Test]
        public void Divide_Int_ReturnsCorrectResult()
        {
            Assert.That(_calculator.Divide(10, 2), Is.EqualTo(5));
        }

        //  Kiểm tra phép chia với số thực
        [Test]
        public void Divide_Float_ReturnsCorrectResult()
        {
            Assert.That(_calculator.Divide(5.0f, 2.0f), Is.EqualTo(2.5f));
        }

        //  Kiểm tra phép chia lấy phần dư
        [Test]
        public void Modulus_ReturnsCorrectRemainder()
        {
            Assert.That(_calculator.Modulus(10, 3), Is.EqualTo(1));
        }


        //  Kiểm tra phép chia với mẫu số bằng 0 (int)
        [Test]
        public void Divide_Int_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }

        //  Kiểm tra phép chia với mẫu số bằng 0 (float)
        [Test]
        public void Divide_Float_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10.5f, 0.0f));
        }

        //  Kiểm tra phép chia lấy phần dư với mẫu số bằng 0
        [Test]
        public void Modulus_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Modulus(10, 0));
        }

        //  EDGE CASES (Biên giới) 

        //  Kiểm tra với giá trị 0
        [Test]
        public void Add_Zero_ReturnsSameValue()
        {
            Assert.That(_calculator.Add(0, 5), Is.EqualTo(5));
        }

        //  Kiểm tra với số âm
        [Test]
        public void Subtract_NegativeNumbers_ReturnsCorrectResult()
        {
            Assert.That(_calculator.Subtract(-5, -3), Is.EqualTo(-2));
        }

        //  Kiểm tra với giá trị lớn
        [Test]
        public void Multiply_LargeNumbers_ReturnsCorrectResult()
        {
            Assert.That(_calculator.Multiply(1000000L, 1000000L), Is.EqualTo(1000000000000));
        }

        //  Kiểm tra với số rất nhỏ
        [Test]
        public void Divide_SmallNumbers_ReturnsCorrectResult()
        {
            Assert.That(_calculator.Divide(0.00001f, 0.0001f), Is.EqualTo(0.1f).Within(0.00001f));
        }

        //  Kiểm tra với số rất lớn (float)
        [Test]
        public void Divide_LargeFloatNumbers_ReturnsCorrectResult()
        {
            float result = _calculator.Divide(1000000000f, 2f);
            Assert.That(result, Is.EqualTo(500000000f));
        }
    }
}
