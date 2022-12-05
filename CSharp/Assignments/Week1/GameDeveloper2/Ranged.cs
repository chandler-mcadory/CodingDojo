class RangedFighter : Enemy
{
    public int FieldDistance;

    public RangedFighter(int FieldDistance = 5) : base("Christophe")
    {

        Attacks.Add(new Attack("arrow", 20));
        Attacks.Add(new Attack("throwing knife", 15));
    }

    public bool DistanceCheck()
    {
        if(FieldDistance < 10)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void RangedAttack()
    {
        if(DistanceCheck())
        {
            Attack RangedAttack = base.RandomAttack();
            System.Console.WriteLine($"You used {RangedAttack.name} dealing {RangedAttack.damage} damage.");
        }
        else
        {
            System.Console.WriteLine($"You're too close to attack!");
        }
    }

    public void Dash()
    {
        FieldDistance = 20;
        RangedAttack();
    }
}