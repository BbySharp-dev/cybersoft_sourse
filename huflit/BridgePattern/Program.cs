using System;

public interface IPrice
{
    void DisplayDetails(string product, double price);
    void GetDiscount(int percentage);
}

public class OnlinePrice : IPrice
{
    public void DisplayDetails(string product, double price)
    {
        Console.WriteLine($"{product} có giá online: {price}$");
    }

    public void GetDiscount(int percentage)
    {
        Console.WriteLine($"Giảm giá online: {percentage}%");
    }
}

public class ShowroomPrice : IPrice
{
    public void DisplayDetails(string product, double price)
    {
        Console.WriteLine($"{product} có giá tại showroom: {price + 300}$");
    }

    public void GetDiscount(int percentage)
    {
        Console.WriteLine($"Giảm giá showroom: {percentage}%");
    }
}

public abstract class ElectronicGoods
{
    protected IPrice price;
    public string type;
    public double cost;

    public ElectronicGoods(IPrice price)
    {
        this.price = price;
    }

    public void Details()
    {
        price.DisplayDetails(type, cost);
    }

    public void Discount(int percentage)
    {
        price.GetDiscount(percentage);
    }
}

public class Television : ElectronicGoods
{
    public Television(IPrice price) : base(price)
    {
        this.type = "Tivi";
        this.cost = 2000;
    }
}

public class DVD : ElectronicGoods
{
    public DVD(IPrice price) : base(price)
    {
        this.type = "Đầu DVD";
        this.cost = 3000;
    }

    public void DoubleDiscount()
    {
        Discount(10);
        Discount(5);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Bridge Pattern Demo ***");

        Console.WriteLine("\nGiá tivi:");
        ElectronicGoods tv = new Television(new OnlinePrice());
        tv.Details();
        tv.Discount(10);

        tv = new Television(new ShowroomPrice());
        tv.Details();
        tv.Discount(10);

        Console.WriteLine("\nGiá đầu DVD:");
        ElectronicGoods dvd = new DVD(new OnlinePrice());
        dvd.Details();
        dvd.Discount(10);

        dvd = new DVD(new ShowroomPrice());
        dvd.Details();
        ((DVD)dvd).DoubleDiscount();
    }
}
