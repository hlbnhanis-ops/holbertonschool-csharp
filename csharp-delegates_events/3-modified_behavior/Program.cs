public enum Modifier
{
    Weak,
    Base,
    Strong
}

public delegate float CalculateModifier(float baseValue, Modifier modifier);

public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private delegate void CalculateHealth(float amount);

    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;

        if(maxHp <= 0)
        {
            this.maxHp = 100f;
            this.hp = 100f;
            System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
    }

    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    public void TakeDamage(float damage)
    {
        if(damage < 0) damage = 0;
        System.Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    public void HealDamage(float heal)
    {
        if(heal < 0) heal = 0;
        System.Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    public void ValidateHP(float newHp)
    {
        if(newHp < 0) hp = 0;
        else if(newHp > maxHp) hp = maxHp;
        else hp = newHp;
    }

    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if(modifier is Modifier.Weak) return baseValue / 2;
        else if(modifier is Modifier.Base) return baseValue;
        else if(modifier is Modifier.Strong) return baseValue * 1.5;
        else return 0;
    }
}