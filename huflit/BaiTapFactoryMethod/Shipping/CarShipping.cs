using System;

public class CarShipping : IShippingMethod
{
    public bool IsEligible(double weight, double distance)
    {
        return weight >= 30 && weight <= 1000 && distance <= 100;
    }

    public double CalculateShippingFee(double weight, double distance)
    {
        return 100000 + (10000 * weight) + (10000 * distance);
    }

    public void DisplayOrderDetails(double weight, double distance)
    {
        Console.WriteLine($"Vận chuyển bằng Ô TÔ");
        Console.WriteLine($"Khối lượng: {weight} kg | Khoảng cách: {distance} km");
        Console.WriteLine($"Tổng cước: {CalculateShippingFee(weight, distance):N0} VNĐ\n");
    }
}
