# WordLib Project


This project was based on Test-Driven Development (TDD) 
and includes classes and test methods to check if a word is a palindrome and to calculate the length of a string.

### Palindrome Checker

Worder class includes a method IsPalindromeWordChecker that checks whether a given word is a palindrome or not. 
The method also takes a string as input and returns the reverse of the input string.

```sh
// Create an instance to test:
Worder worder = new Worder();

// expected output
string expectedResult = "radar";

string inputWord = "radar";

// Run the method under test:
string actualResult = worder.IsPalindromeWordChecker(inputWord);

// Assert / Verify the result:
Assert.AreEqual(expectedResult, actualResult);

```

## String Length Calculator

Worder class includes a method CheckingStringLength that calculates the length of a given string.

Example: 

```sh
int expectedOutput = 9;
string inputWord = "Stockholm";

// Run the method under test:
int actualResult = worder.CheckingStringLength(inputWord);

// Assert / Verify the result:
Assert.AreEqual(expectedOutput, actualResult);

```


