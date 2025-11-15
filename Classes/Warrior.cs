public class Warrior
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Warrior(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
    }
}