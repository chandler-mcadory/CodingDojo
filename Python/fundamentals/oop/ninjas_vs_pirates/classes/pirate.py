import random

class Pirate:

    def __init__( self , name ):
        self.name = name
        self.strength = 15
        self.hit = 3
        self.health = 100
        self.defense = 7
        self.isdef = False

    def show_stats( self ):
        print(f"Name: {self.name}\nStrength: {self.strength}\nHit: {self.hit}\nHealth: {self.health}\n")

    def attack ( self , ninja ):
        roll = random.randint(1,self.hit)
        if roll != self.hit:
            if ninja.isdef == True:
                print(f"{ninja.name} blocked {self.strength} damage!")
            else:
                ninja.health -= self.strength
                print(f'Attack hit {ninja.name}!')
                print(f'{ninja.name} Health: {ninja.health}')
        else: 
            print(f'Attack missed!')
        ninja.isdef = False
        return self
    
    def defend (self, ninja):
        roll = random.randint(1,self.defense)
        if roll == self.defense:
            self.isdef = True
            print(f"{self.name} is defending!")
        else:
            print(f"{self.name}'s block failed!")

        ninja.isdef = False
        return self

    def birdbomb (self, ninja):
        ninja.hit += 2
        print(f"CAAAW CAAAW. {ninja.name}'s eyes have been compromised!")
        print(f"{ninja.name} hit decreased by 2.")
        ninja.isdef = False
        return self



