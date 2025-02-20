class Program
{
    static void Main()
    {
        Console.WriteLine("CHƯƠNG TRÌNH TÍNH CƯỚC VẬN CHUYỂN ***\n");

        Console.Write("Nhập khối lượng hàng hóa (kg): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Nhập khoảng cách vận chuyển (km): ");
        double distance = double.Parse(Console.ReadLine());

        IShippingMethod method = ShippingFactory.GetShippingMethod(weight, distance);
        method.DisplayOrderDetails(weight, distance);

        Console.ReadKey();
    }
}
