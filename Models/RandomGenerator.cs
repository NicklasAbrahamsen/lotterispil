public class RandomGenerator
{
    private Random random;

    public RandomGenerator()
    {
        random = new Random();
    }

    public decimal GenerateWinAmount()
    {
        return random.Next(25, 251);
    }

    public int GenerateRandomNumber(int min, int max)
    {
        return random.Next(min, max + 1);
    }
}
