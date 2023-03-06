public class Game
{
    public int NumberOfBoxes { get; set; }
    public List<Box> Boxes { get; set; }
    public decimal RTP { get; set; }
    public decimal TotalWin { get; set; }
    public bool Started { get; set; }
    public decimal Balance { get; set; }

    public Game(int numberOfBoxes, decimal rtp, decimal balance)
    {
        NumberOfBoxes = numberOfBoxes;
        RTP = rtp;
        Started = false;
        Balance = balance;
        InitializeBoxes();
    }

    private void InitializeBoxes()
    {
        Boxes = new List<Box>();
        for (int i = 0; i < NumberOfBoxes; i++)
        {
            string name = "Heidis bier bar";
            decimal price = 0;
            if (i == 0)
            {
                price = 50;
            }
            else if (i == 1)
            {
                price = 100;
            }
            else
            {
                price = 200;
            }
            Box box = new Box(name, price);
            Boxes.Add(box);
        }
    }

    public void Start()
    {
        RandomGenerator generator = new RandomGenerator();
        Boxes = Boxes.OrderBy(b => generator.GenerateRandomNumber(0, 20)).ToList();
        Started = true;
    }

    public void End()
    {
        foreach (var box in Boxes)
        {
            box.Open();
        }

        TotalWin = Boxes.Sum(b => b.WinAmount);
        Balance += TotalWin - Boxes.Sum(b => b.Price); // Update the balance based on the total win amount and the total price of the boxes
    }
}






