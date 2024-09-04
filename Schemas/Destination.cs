namespace Artifacts.Schemas;

public class Destination
{
    public string Name { get; set; } = null!;
    public string Skin { get; set; } = null!;
    public int X { get; set; }
    public int Y { get; set; }
    public Content? Content { get; set; }
}