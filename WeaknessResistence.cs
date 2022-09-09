namespace pokemon;

public abstract class WeaknessResistance
{
    public WeaknessResistance(EnergyTypes energyType, float multiplier)
    {
        this.energyType = energyType;
        this.multiplier = multiplier;
    }

    public EnergyTypes energyType { get; set; }
    public float multiplier { get; set; }
}

public class Weakness : WeaknessResistance
{
    public Weakness(EnergyTypes energyType, float multiplier) : base(energyType, multiplier)
    {
    }
}

public class Resistance : WeaknessResistance
{
    public Resistance(EnergyTypes energyType, float multiplier) : base(energyType, multiplier)
    {
    }
}
