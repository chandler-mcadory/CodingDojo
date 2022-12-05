class MagicCaster : Enemy
{
    public MagicCaster(int h = 80) : base("Harold")
    {
        health = h;
        Attacks.Add(new Attack("Staff Strike", 15));
        Attacks.Add(new Attack("Shield", 0));
        Attacks.Add(new Attack("Fireball", 25));
    }

    public void RandomMagic()
    {
        Attack MagicAttack = base.RandomAttack();

        System.Console.WriteLine($"You used {MagicAttack.name} dealing {MagicAttack.damage} damage.");
    }

    public void Heal(Enemy target)
    {
        target.health += 40;

        System.Console.WriteLine($"You healed {target.name}. Now they have {target.health} health.");
    }
}