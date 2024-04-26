using programming_1_partial_2.Classes;
using programming_1_partial_2.Classes.ChildClasses;

Pikachu pikachu = new Pikachu("Pikachu", 5, 50, 25, 15, 25, 0, 100);
Charmander charmander = new Charmander("Charmander", 5, 60, 25, 20, 20, 0, 100);

Console.WriteLine("Estado inicial de los Pokémon:");
Console.WriteLine($"Pikachu:\n{pikachu.ShowInfo()}\n");
Console.WriteLine($"Charmander:\n{charmander.ShowInfo()}\n");

Console.WriteLine("¡Comienza la batalla!");
while (pikachu.Health > 0 && charmander.Health > 0)
{
    pikachu.AttackEnemy(charmander);
    Console.WriteLine($"Pikachu ataca a Charmander. Salud restante de Charmander: {charmander.Health}");

    if (charmander.Health <= 0)
    {
        Console.WriteLine("Charmander ha sido derrotado. Pikachu gana la batalla!");
        break;
    }

    charmander.AttackEnemy(pikachu);
    Console.WriteLine($"Charmander ataca a Pikachu. Salud restante de Pikachu: {pikachu.Health}");

    if (pikachu.Health <= 0)
    {
        Console.WriteLine("Pikachu ha sido derrotado. Charmander gana la batalla!");
        break;
    }

    Console.WriteLine(); 
}

Console.ReadLine();