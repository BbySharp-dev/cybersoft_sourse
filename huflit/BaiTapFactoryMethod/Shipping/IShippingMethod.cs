public interface IShippingMethod
{
    bool IsEligible(double weight, double distance);
    double CalculateShippingFee(double weight, double distance);
    void DisplayOrderDetails(double weight, double distance);
}
