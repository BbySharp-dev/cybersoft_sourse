using System;

namespace CSharpCourse
{
    class Lesson41
    {
        static void Main()
        {
            // nhập vào số bộ test
            int t = int.Parse(Console.ReadLine());
            // lần lượt nhập từng bộ test
            for (int i = 1; i <= t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                // kiểm tra và đưa ra kết luận n có hoàn hảo không
                if (IsPerfectNumber(n))
                {
                    Console.WriteLine($"Test {i}: YES");
                }
                else
                {
                    Console.WriteLine($"Test {i}: NO");
                }
            }
            
            
            int a = 1;
            int b = 30;
            int k = 6;
            ListedDivisibleByK(a, b, k);
        }
        
        /// <summary>
        /// Phương thức liệt kê các số chia hết cho k khác 0 trong đoạn a đến b.
        /// </summary>
        /// <param name="a">Tham số a</param>
        /// <param name="b">Tham số b</param>
        /// <param name="k">Tham số k</param>
        static void ListedDivisibleByK(int a, int b, int k)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % k == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        
        
        static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            // tính tổng ước
            for (int k = 1; k < number; k++)
            {
                if (number % k == 0)
                {
                    sum += k;
                }
            }
            return sum == number;
        }
    }
}