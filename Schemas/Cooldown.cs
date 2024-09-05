namespace Artifacts.Schemas;
public class Cooldown
{
    public int TotalSeconds { get; set; }
    public int RemainingSeconds { get; set; }
    public DateTime StartedAt { get; set; }
    public DateTime Expiration { get; set; }
    public string Reason { get; set; } = null!;

    public void WaitDisplay()
    {
        for (int i = 1; i <= RemainingSeconds; i++)
        {
            Console.Write("\r");
            Console.Write($"Cooldown: {i}/{RemainingSeconds} secs");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}