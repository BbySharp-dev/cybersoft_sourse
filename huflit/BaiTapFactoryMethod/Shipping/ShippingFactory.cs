public class ShippingFactory
{
    public static IShippingMethod GetShippingMethod(double weight, double distance)
    {
        IShippingMethod method;

        if (new MotorbikeShipping().IsEligible(weight, distance))
        {
            method = new MotorbikeShipping();
        }
        else if (new CarShipping().IsEligible(weight, distance))
        {
            method = new CarShipping();
        }
        else
        {
            method = new AirplaneShipping();
        }

        return method;
    }
}
