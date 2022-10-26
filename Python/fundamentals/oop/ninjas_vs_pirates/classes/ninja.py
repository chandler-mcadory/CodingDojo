import random

class Ninja:

    def __init__( self , name ):
        self.name = name
        self.strength = 10
        self.hit = 5
        self.health = 100
        self.defense = 4
        self.isdef = False
    
    def show_stats( self ):
        print(f"Name: {self.name}\nStrength: {self.strength}\nHit: {self.hit}\nHealth: {self.health}\n")

    def attack ( self , pirate ):
        roll = random.randint(1,self.hit)
        if roll != self.hit:
            if pirate.isdef == True:
                print(f"{pirate.name} blocked {self.strength} damage!")
            else:
                pirate.health -= self.strength
                print(f'Attack hit {pirate.name}!')
                print(f'{pirate.name} Health: {pirate.health}')
        else: 
            print(f'Attack missed!')
        pirate.isdef = False
        return self

    def defend (self, pirate):
        roll = random.randint(1,self.defense)
        if roll == self.defense:
            isdef = True
            print(f"{self.name} is defending next turn!")
        else:
            print(f"{self.name} attempted to block next turn!")

        pirate.isdef = False
        return self