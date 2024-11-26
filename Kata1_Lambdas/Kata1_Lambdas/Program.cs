namespace Kata1_Lambdas;

class Program
{
    static void Main(string[] args)
    {
        var warrior = new Character("Warrior",30,() => Console.WriteLine("Warrior attacks with a sword!"));
        var healer = new Character("Healer",60,() => Console.WriteLine("Healer heals!"));
        
        List<Character> characters = new List<Character> { warrior, healer };
        
        if (warrior.Health < 50)
        {
            warrior.PerformAction();
        }
        
        if (healer.Health >= 50)
        {
            var characterToHeal = characters.Where(c => c.Health < 50).OrderBy(c => c.Health).FirstOrDefault();
            if (characterToHeal != null)
            {
                Console.WriteLine($"{healer.Name} heals {characterToHeal.Name}.");
                characterToHeal.Health += 20;
                healer.PerformAction();
            }
            else
            {
                Console.WriteLine("Healer has no one to heal!");
            }
        }

        characters.Where(c => c.Health < 50).ToList().ForEach(c =>
            {
                if (c.Name == "Warrior")
                {
                    c.PerformAction();
                }
                else if (c.Name == "Healer")
                {
                    c.PerformAction();
                }

            }
        );
    }
}