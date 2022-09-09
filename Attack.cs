namespace pokemon;

public class Attack
{
    public Attack(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public string name { get; set; }
    public int damage { get; set; }
}
