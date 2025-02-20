using System;

public class AirplaneShipping : IShippingMethod
{
    public bool IsEligible(double weight, double distance)
    {
        return true;
    }

    public double CalculateShippingFee(double weight, double distance)
    {
        return 500000 + (20000 * weight) + (30000 * distance);
    }

    public void DisplayOrderDetails(double weight, double distance)
    {
        Console.WriteLine($"Vận chuyển bằng MÁY BAY");
        Console.WriteLine($"Khối lượng: {weight} kg | Khoảng cách: {distance} km");
        Console.WriteLine($"Tổng cước: {CalculateShippingFee(weight, distance):N0} VNĐ\n");
    }
}
