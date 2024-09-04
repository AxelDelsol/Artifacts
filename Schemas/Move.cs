namespace Artifacts.Schemas;

public class Move
{
    public Cooldown Cooldown { get; set; } = null!;
    public Destination Destination { get; set; } = null!;
    public Character Character { get; set; } = null!;
}
