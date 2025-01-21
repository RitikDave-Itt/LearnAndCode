import random

def rollTheDice(diceSurfaces):
    outputNumber=random.randint(1, diceSurfaces)
    return outputNumber


def main():
    diceSurfaces=6
    rollTheDiceAgain=True
    while rollTheDiceAgain:
        userInput=input("Ready to roll? Enter Q to Quit")
        if userInput.lower() !="q":
            outputNumber=rollTheDice(diceSurfaces)
            print("You have rolled a",outputNumber)
        else:
            rollTheDiceAgain=False

main()