using pokemon;

var Pickachu = new Pokemon(
    "Pickachu",
    EnergyTypes.Lightning,
    60,
    new List<Attack> { new("Electric Ring", 50), new("Pika Punch", 20) },
    new Weakness(EnergyTypes.Fire, 1.5f),
    new Resistance(EnergyTypes.Fighting, 20.0f)
);
var Charmeleon = new Pokemon(
    "Charmeleon",
    EnergyTypes.Fire,
    60,
    new List<Attack> { new("Head Butt", 10), new("Flare", 30) },
    new Weakness(EnergyTypes.Water, 2.0f),
    new Resistance(EnergyTypes.Lightning, 10.0f)
);
Console.WriteLine("--------------------");

Console.WriteLine(@"
██████╗  ██████╗ ██╗  ██╗███████╗███╗   ███╗ ██████╗ ███╗   ██╗
██╔══██╗██╔═══██╗██║ ██╔╝██╔════╝████╗ ████║██╔═══██╗████╗  ██║
██████╔╝██║   ██║█████╔╝ █████╗  ██╔████╔██║██║   ██║██╔██╗ ██║
██╔═══╝ ██║   ██║██╔═██╗ ██╔══╝  ██║╚██╔╝██║██║   ██║██║╚██╗██║
██║     ╚██████╔╝██║  ██╗███████╗██║ ╚═╝ ██║╚██████╔╝██║ ╚████║
╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝                                                                              
");
Console.WriteLine("--------------------");

void PlayFight()
{
    Console.WriteLine("Pickachu attacks Charmeleon with Electric Ring");
    Pickachu.Attack(Charmeleon, Pickachu.attacks[0]);
    Console.WriteLine("Pickachu has {0} HP left", Pickachu.health);
    Console.WriteLine("Charmeleon has {0} HP left", Charmeleon.health);
    Console.WriteLine();
    Console.WriteLine("Charmeleon attacks Pickachu with Flare");
    Charmeleon.Attack(Pickachu, Charmeleon.attacks[1]);
    Console.WriteLine("Pickachu has {0} HP left", Pickachu.health);
    Console.WriteLine("Charmeleon has {0} HP left", Charmeleon.health);
    Console.WriteLine("Pickachu departed, fight ended");
    Console.WriteLine();
}

PlayFight();
Console.WriteLine("Pokemon population health: {0}", Pokemon.getPopulationHealth());
