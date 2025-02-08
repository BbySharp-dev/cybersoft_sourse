namespace CalculatorLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            Console.WriteLine($"2 + 3 = {calc.Add(2, 3)}");
            Console.WriteLine($"2.5 + 3.7 = {calc.Add(2.5f, 3.7f)}");

            Console.WriteLine($"10 - 4 = {calc.Subtract(10, 4)}");
            Console.WriteLine($"10.5 - 4.2 = {calc.Subtract(10.5f, 4.2f)}");

            Console.WriteLine($"6 * 3 = {calc.Multiply(6, 3)}");
            Console.WriteLine($"6.2 * 3.1 = {calc.Multiply(6.2f, 3.1f)}");

            Console.WriteLine($"8 / 2 = {calc.Divide(8, 2)}");
            Console.WriteLine($"8.5 / 2.5 = {calc.Divide(8.5f, 2.5f)}");

            Console.WriteLine($"10 % 3 = {calc.Modulus(10, 3)}");

            // Kiểm tra chia cho 0
            try
            {
                Console.WriteLine($"10 / 0 = {calc.Divide(10, 0)}"); 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
}