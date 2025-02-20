using System;

public class MotorbikeShipping : IShippingMethod
{
    public bool IsEligible(double weight, double distance)
    {
        return weight < 30 && distance <= 10;
    }

    public double CalculateShippingFee(double weight, double distance)
    {
        return 15000 + (5000 * weight) + (3000 * distance);
    }

    public void DisplayOrderDetails(double weight, double distance)
    {
        Console.WriteLine($"Vận chuyển bằng XE MÁY");
        Console.WriteLine($"Khối lượng: {weight} kg | Khoảng cách: {distance} km");
        Console.WriteLine($"Tổng cước: {CalculateShippingFee(weight, distance):N0} VNĐ\n");
    }
}
