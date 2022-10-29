using EntityObjects.src;
using TestApp;

ObjectManager om = new ObjectManager(new UnitDataFactory("../../../Data/Units"));

Player player = (Player)om.GetObject(typeof(Player));
Console.WriteLine(player.MaxHealth);

Goblin goblin = (Goblin)om.GetObject(typeof(Goblin));
Console.WriteLine(goblin.MaxHealth);
