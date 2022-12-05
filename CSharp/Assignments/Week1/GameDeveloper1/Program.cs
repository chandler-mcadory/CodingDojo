Enemy skeleton = new Enemy("Bones");

Attack sword = new Attack("Sword", 10);
Attack kick = new Attack("Kick", 3);
Attack bash = new Attack("Shield Bash", 5);

skeleton.Attacks.Add(sword);
skeleton.Attacks.Add(kick);
skeleton.Attacks.Add(bash);

Random r = new Random();
int RandomAttack = r.Next(0, skeleton.Attacks.Count);

System.Console.WriteLine(skeleton.Attacks[RandomAttack].name);