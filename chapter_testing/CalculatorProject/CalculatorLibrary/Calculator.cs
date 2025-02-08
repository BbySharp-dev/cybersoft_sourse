namespace CalculatorLibrary
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Không thể chia cho 0");
            return a / b;
        }
        public int Modulus(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Không thể chia cho 0");
            return a % b;
        }

        public float Add(float a, float b) => a + b;
        public float Subtract(float a, float b) => a - b;
        public float Multiply(float a, float b) => a * b;
        public float Divide(float a, float b)
        {
            if (b == 0)
                throw new DivideByZeroException("Không thể chia cho 0");
            return a / b;
        }
    }
}