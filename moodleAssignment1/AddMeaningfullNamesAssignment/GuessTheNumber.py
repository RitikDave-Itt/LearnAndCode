import random
def isValidInput(userInput):
    if userInput.isdigit() and 1<= int(userInput) <=100:
        return True
    else:
        return False

def main():
    answer=random.randint(1,100)
    correctguess=False
    userInput=input("Guess a number between 1 and 100:")
    numbeOfGuesses=0
    while not correctguess:
        if not isValidInput(userInput):
            userInput=input("I wont count this one Please enter a number between 1 to 100")
            continue
        else:
            numbeOfGuesses+=1
            userInput=int(userInput)

        if userInput<answer:
            userInput=input("Too low. Guess again")
        elif userInput>answer:
            userInput=input("Too High. Guess again")
        else:
            print("You guessed it in",numbeOfGuesses,"guesses!")
            correctguess=True


main()