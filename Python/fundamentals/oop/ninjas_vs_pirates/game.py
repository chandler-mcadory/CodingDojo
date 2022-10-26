from classes.ninja import Ninja
from classes.pirate import Pirate
import random

michelangelo = Ninja("Michelanglo")

jack_sparrow = Pirate("Jack Sparrow")

while michelangelo.health > 0 and jack_sparrow.health > 0:
    response = ""
    while not response == "1" and not response == "2" and not response == "3":
        print("Would you like 1) Attack or 2) Defend or 3) Bird Bomb")
        response = input(">>>>")
        print("=====player turn=====")
        if response == "1":
            jack_sparrow.attack(michelangelo)
        if response == "2":
            jack_sparrow.defend(michelangelo)
        if response == "3":
            jack_sparrow.birdbomb(michelangelo)
    print("")


    roll = random.randint(1,2)
    if roll == 1:
        print("=====enemy turn=====")
        michelangelo.attack(jack_sparrow)
    else:
        michelangelo.defend(jack_sparrow)
    print("")

    print("=====round update=====")
    jack_sparrow.show_stats()
    michelangelo.show_stats()
    print("")