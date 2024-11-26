namespace Kata1_Lambdas;
public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public Action PrimaryAction { get; set; }
    public Character(string name, int health, Action primaryAction)
    {
        Name = name;
        Health = health;
        PrimaryAction = primaryAction;
    }
    public void PerformAction()
    {
        PrimaryAction.Invoke();
    }
}