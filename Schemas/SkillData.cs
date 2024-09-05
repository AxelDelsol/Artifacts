using Artifacts.Utils;

namespace Artifacts.Schemas;

public class SkillData : ICooldown
{
    public Cooldown Cooldown { get; set; } = null!;
    public SkillInfo Details { get; set; } = null!;
    public Character Character { get; set; } = null!;
}