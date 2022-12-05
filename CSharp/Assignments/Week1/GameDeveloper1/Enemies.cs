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

    
}