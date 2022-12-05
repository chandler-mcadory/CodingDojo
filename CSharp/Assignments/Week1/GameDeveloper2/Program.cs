MeleeFighter barbarian = new MeleeFighter();
RangedFighter rogue = new RangedFighter();
MagicCaster wizard = new MagicCaster();

barbarian.Rage();

rogue.RangedAttack();
rogue.Dash();

wizard.RandomMagic();
wizard.Heal(wizard);
wizard.Heal(rogue);
wizard.Heal(barbarian);