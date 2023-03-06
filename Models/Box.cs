public class Box
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal WinAmount { get; set; }

    public Box(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void Open()
    {
        RandomGenerator generator = new RandomGenerator();
        WinAmount = generator.GenerateWinAmount();
    }
}


