using System;

public class Computer
{
    public string CPU { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }
    public string GPU { get; set; } = "None"; // Mặc định không có GPU

    public void ShowConfiguration()
    {
        Console.WriteLine("Computer Configuration:");
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM}GB");
        Console.WriteLine($"Storage: {Storage}GB SSD");
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine("----------------------");
    }
}