def isArmstrongNumber(inputNumber):
    
    armstrongSum = 0
    digitCount = 0

    
    tempNumber = inputNumber
    while tempNumber > 0:
        digitCount += 1
        tempNumber=tempNumber// 10

    
    tempNumber = inputNumber
    while tempNumber > 0:
        remainder = tempNumber % 10
        armstrongSum += remainder ** digitCount
        tempNumber //= 10

    return armstrongSum


userInput = int(input("\nPlease Enter the Number to Check for Armstrong: "))

if userInput == isArmstrongNumber(userInput):
    print("\n %d is Armstrong Number.\n" % userInput)
else:
    print("\n %d is Not a Armstrong Number.\n" % userInput)
