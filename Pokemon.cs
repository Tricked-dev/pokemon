namespace pokemon;

public class Pokemon
{
    private static readonly List<Pokemon> pokemons = new();

    public Pokemon(string name, EnergyTypes energyType, int hitpoints, List<Attack> attacks, Weakness weaknesses,
        Resistance resistances)
    {
        this.name = name;
        this.energyType = energyType;
        this.hitpoints = hitpoints;
        health = hitpoints;
        this.attacks = attacks;
        weakness = weaknesses;
        resistance = resistances;

        pokemons.Add(this);
    }

    public string name { get; set; }
    public EnergyTypes energyType { get; set; }
    public float hitpoints { get; set; }
    public float health { get; set; }
    public List<Attack> attacks { get; set; }
    public Weakness weakness { get; set; }
    public Resistance resistance { get; set; }

    public void Attack(Pokemon pokemon, Attack attack)
    {
        if (energyType == pokemon.weakness.energyType)
        {
            pokemon.health -= attack.damage * pokemon.weakness.multiplier;
        }
        else if (energyType == pokemon.resistance.energyType)
        {
            pokemon.health -= attack.damage - pokemon.resistance.multiplier;
        }

        if (pokemon.IsAlive())
        {
            return;
        }

        pokemon.health = 0;
        pokemons.Remove(pokemon);
    }

    public bool IsAlive()
    {
        if (health > 0)
        {
            return true;
        }

        return false;
    }

    public static int getPopulationHealth()
    {
        var totalHealth = 0f;
        foreach (var pokemon in pokemons)
        {
            totalHealth += pokemon.health;
        }

        return (int)totalHealth / pokemons.Count;
    }
}
