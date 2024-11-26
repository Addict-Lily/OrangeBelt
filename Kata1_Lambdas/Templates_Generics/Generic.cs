namespace Templates_Generics;

public interface IAbility
{
    string Name { get; set; }
    string Effect { get; set; }
}

public class AttackAbility : IAbility
    {
        public string Name { get; set; }
        public string Effect { get; set; }

        public AttackAbility(string name, string effect)
        {
            Name = name;
            Effect = effect;
        }
    }
public class HealAbility : IAbility
{
    public string Name { get; set; }
    public string Effect { get; set; }

    public HealAbility(string name, string effect)
    {
        Name = name;
        Effect = effect;
    }
}
public class AbilityContainer<T> where T : IAbility
{
    private List<T> _abilities = new();

    public void AddAbility(T ability)
    {
        _abilities.Add(ability);
    }

    public bool RemoveAbility(T ability)
    {
        return _abilities.Remove(ability);
    }

    public T GetAbility(string name)
    {
        return _abilities.FirstOrDefault(a => a.Name == name);

    }

    public IEnumerable<T> GetAbilities()
    {
        return _abilities;
    }

    public void DisplayAbilities()
    {
        Console.WriteLine("Abilities List: ");
        foreach (var ability in _abilities)
        {
            Console.WriteLine($"- {ability.Name} : {ability.Effect}");
        }
    }
}