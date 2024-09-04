namespace Artifacts.Schemas;
public class Character
{
    public string Name { get; set; } = null!;
    public string Skin { get; set; } = null!;
    public int Level { get; set; }
    public int Xp { get; set; }
    public int MaxXp { get; set; }
    public int AchievementsPoints { get; set; }
    public int Gold { get; set; }
    public int Speed { get; set; }
    public int MiningLevel { get; set; }
    public int MiningXp { get; set; }
    public int MiningMaxXp { get; set; }
    public int WoodcuttingLevel { get; set; }
    public int WoodcuttingXp { get; set; }
    public int WoodcuttingMaxXp { get; set; }
    public int FishingLevel { get; set; }
    public int FishingXp { get; set; }
    public int FishingMaxXp { get; set; }
    public int WeaponcraftingLevel { get; set; }
    public int WeaponcraftingXp { get; set; }
    public int WeaponcraftingMaxXp { get; set; }
    public int GearcraftingLevel { get; set; }
    public int GearcraftingXp { get; set; }
    public int GearcraftingMaxXp { get; set; }
    public int JewelrycraftingLevel { get; set; }
    public int JewelrycraftingXp { get; set; }
    public int JewelrycraftingMaxXp { get; set; }
    public int CookingLevel { get; set; }
    public int CookingXp { get; set; }
    public int CookingMaxXp { get; set; }
    public int Hp { get; set; }
    public int Haste { get; set; }
    public int CriticalStrike { get; set; }
    public int Stamina { get; set; }
    public int AttackFire { get; set; }
    public int AttackEarth { get; set; }
    public int AttackWater { get; set; }
    public int AttackAir { get; set; }
    public int DmgFire { get; set; }
    public int DmgEarth { get; set; }
    public int DmgWater { get; set; }
    public int DmgAir { get; set; }
    public int ResFire { get; set; }
    public int ResEarth { get; set; }
    public int ResWater { get; set; }
    public int ResAir { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Cooldown { get; set; }
    public DateTime CooldownExpiration { get; set; }
    public string WeaponSlot { get; set; } = null!;
    public string ShieldSlot { get; set; } = null!;
    public string HelmetSlot { get; set; } = null!;
    public string BodyArmorSlot { get; set; } = null!;
    public string LegArmorSlot { get; set; } = null!;
    public string BootsSlot { get; set; } = null!;
    public string Ring1Slot { get; set; } = null!;
    public string Ring2Slot { get; set; } = null!;
    public string AmuletSlot { get; set; } = null!;
    public string Artifact1Slot { get; set; } = null!;
    public string Artifact2Slot { get; set; } = null!;
    public string Artifact3Slot { get; set; } = null!;
    public string Consumable1Slot { get; set; } = null!;
    public int Consumable1SlotQuantity { get; set; }
    public string Consumable2Slot { get; set; } = null!;
    public int Consumable2SlotQuantity { get; set; }
    public string Task { get; set; } = null!;
    public string TaskType { get; set; } = null!;
    public int TaskProgress { get; set; }
    public int TaskTotal { get; set; }
    public int InventoryMaxItems { get; set; }
    public Inventory[] Inventory { get; set; } = null!;
}