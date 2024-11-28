namespace Delegates;

class Program
{
    static void Main(string[] args)
    {
        Character elf = new Character("Elf", 100);
        Character witch = new Character("Witch", 80);
        
        elf.HealthChanged += HandleHealthChanged;
        witch.HealthChanged += HandleHealthChanged;
        
        Console.WriteLine("Elf attacks Witch!");
        elf.Attack(witch);
        
        Console.WriteLine("\nWitch attacks Elf!");
        witch.Attack(elf);
        
        Console.WriteLine("\nElf attacks witch again!");
        elf.Attack(witch);
        
        static void HandleHealthChanged(Character character, int damage)
        {
            Console.WriteLine($"{character.Name}'s health reduced by {damage}. Now is {character.Health}");
        }
    }
}