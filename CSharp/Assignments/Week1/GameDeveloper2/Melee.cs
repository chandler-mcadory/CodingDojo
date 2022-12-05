class MeleeFighter : Enemy
{
    public MeleeFighter(int h = 120) : base("Baurus")
    {
        health = h;
        Attacks.Add(new Attack("punch", 20));
        Attacks.Add(new Attack("kick", 15));
        Attacks.Add(new Attack("tackle", 25));
    }

    public void Rage()
    {
        Attack RageAttack = base.RandomAttack();
        RageAttack.damage += 10;

        System.Console.WriteLine($"You used {RageAttack.name} dealing {RageAttack.damage} damage.");
    }
}