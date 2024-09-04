namespace Artifacts.Schemas;

public class Inventory
{
    public int Slot { get; set; }
    public string Code { get; set; } = null!;
    public int Quantity { get; set; }
}
