using System;

public sealed class Singleton
{
    private static readonly Singleton _instance = new Singleton();
    private static int _soLuongInstance = 0;

    private Singleton()
    {
        Console.WriteLine("Đang tạo đối tượng Singleton");
        _soLuongInstance++;
        Console.WriteLine($"Số lượng instance được tạo: {_soLuongInstance}");
    }

    public static Singleton Instance
    {
        get
        {
            Console.WriteLine("Singleton đã tồn tại");
            return _instance;
        }
    }
}
