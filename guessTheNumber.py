import random

def is_valid_number(user_input):
    if user_input.isdigit() and 1 <= int(user_input) <= 100:
        return True
    else:
        return False

def play_guessing_game():
    target_number = random.randint(1, 100)
    guessed_correctly = False
    guess = input("Guess a number between 1 and 100:")
    number_of_guesses = 0

    while not guessed_correctly:
        if not is_valid_number(guess):
            guess = input("I wont count this one Please enter a number between 1 to 100")
            continue
        else:
            number_of_guesses += 1
            guess = int(guess)

        if guess < target_number:
            guess = input("Too low. Guess again")
        elif guess > target_number:
            guess = input("Too High. Guess again")
        else:
            print("You guessed it in", number_of_guesses, "guesses!")
            guessed_correctly = True

play_guessing_game()
