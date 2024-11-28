namespace Delegates;

public delegate void CharacterAction(Character target);
public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
    public event Action<Character, int> HealthChanged;

    public void Attack(Character target)
    {
        CharacterAction attackAction = DealDamage;
        attackAction(target);
    }

    private void DealDamage(Character target)
    {
        int damage = 10;
        target.ReduceHealth(damage);
    }
    private void ReduceHealth(int damage)
    {
        Health -= damage;
        if (Health <= 0) Health = 0;

        HealthChanged?.Invoke(this, damage);
    }
}