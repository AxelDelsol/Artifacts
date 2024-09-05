using Artifacts.Schemas;

namespace Artifacts.Utils;
public interface ICooldown
{
    Cooldown Cooldown { get; set; }
}

public static class CooldownExtensions
{
    public static void WaitDisplay(this ICooldown value)
    {
        value.Cooldown.WaitDisplay();
    }
}