class Enemy
{
    public string name;
    public int health = 100;
    public List<Attack> Attacks;


    public Enemy(string n)
    {
        name = n;
        Attacks = new List<Attack>();
    }

    
    public Attack RandomAttack()
    {
        Random r = new Random();
        int RandomAttack = r.Next(0, this.Attacks.Count);
        return this.Attacks[RandomAttack];
    }
}