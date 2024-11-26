namespace Templates_Generics;

class Program
{
    static void Main(string[] args)
    {
        AbilityContainer<IAbility> abilityContainer = new();
        abilityContainer.AddAbility(new AttackAbility("Fireball", "Deals 50 fire damage."));
        abilityContainer.AddAbility(new AttackAbility("Ice Blast", "Deals 40 ice damage."));
        
        AbilityContainer<HealAbility> healAbilityContainer = new();
        healAbilityContainer.AddAbility(new HealAbility("Healing Light", "Restores 30 health points."));
        
        Console.WriteLine("Attack Abilities: ");
        foreach (var attackAbility in abilityContainer.GetAbilities())
        {
            Console.WriteLine($"Name: {attackAbility.Name}");
            Console.WriteLine($"Effect: {attackAbility.Effect}");
            Console.WriteLine();
        }
        
        Console.WriteLine("Heal Abilities: ");
        foreach (var healAbility in healAbilityContainer.GetAbilities())
        {
            Console.WriteLine($"Name: {healAbility.Name}");
            Console.WriteLine($"Effect: {healAbility.Effect}");
            Console.WriteLine();
        }
        Console.WriteLine("Attack Abilities:");
        abilityContainer.DisplayAbilities();
        
        Console.WriteLine("Healing Abilities:");
        healAbilityContainer.DisplayAbilities();
    }
}