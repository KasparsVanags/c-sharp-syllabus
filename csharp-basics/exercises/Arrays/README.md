# Exercises

## Exercise #1

See [Exercise1](./Arrays/Exercise1)

## Exercise #2

See [Exercise2](./Arrays/Exercise2)

## Exercise #3

See [Exercise3](./Arrays/Exercise3)

## Exercise #4

See [Exercise4](./Arrays/Exercise4)

## Exercise #5

See [Exercise5](./Arrays/Exercise5)

## Exercise #6

Write a program that creates an array of ten integers.
It should put ten random numbers from 1 to 100 in the array.
It should copy all the elements of that array into another array of the same size.

Then display the contents of both arrays. To get the output to look like this, you'll need a several for loops.

  - Create an array of ten integers
  - Fill the array with ten random numbers (1-100)
  - Copy the array into another array of the same capacity
  - Change the last value in the first array to a -7
  - Display the contents of both arrays
  
```
Array 1: 45 87 39 32 93 86 12 44 75 -7
Array 2: 45 87 39 32 93 86 12 44 75 50
```

## Exercise #7

See [TicTacToe](./Arrays/TicTacToe)

Code an interactive, two-player game of Tic-Tac-Toe. You'll use a two-dimensional array of chars.

```
(...a game already in progress)

	X   O
	O X X
	  X O
 
'O', choose your location (row, column): 0 1

	X O O
	O X X
	  X O
 
'X', choose your location (row, column): 2 0

	X O O
	O X X
	X X O

The game is a tie.
```

## Exercise #8

Write a program to play a word-guessing game like Hangman.

  - It must randomly choose a word from a list of words.
  - It must stop when all the letters are guessed.
  - It must give them limited tries and stop after they run out.
  - It must display letters they have already guessed (either only the incorrect guesses or all guesses).
  
```
-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	_ _ _ _ _ _ _ _ _ 

Misses:	

Guess:	e

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	_ e _ _ _ _ _ _ _ 

Misses:	

Guess:	i

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	_ e _ i _ _ _ _ _ 

Misses:	

Guess:	a

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	_ e _ i a _ _ a _ 

Misses:	

Guess:	r

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	_ e _ i a _ _ a _ 

Misses:	r

Guess:	s

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	_ e _ i a _ _ a _ 

Misses:	rs

Guess:	t

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	_ e _ i a t _ a _ 

Misses:	rs

Guess:	n

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	_ e _ i a t _ a n 

Misses:	rs

Guess:	o

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	_ e _ i a t _ a n 

Misses:	rso

Guess:	l

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	l e _ i a t _ a n 

Misses:	rso

Guess:	v

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	l e v i a t _ a n 

Misses:	rso

Guess:	h

-=-=-=-=-=-=-=-=-=-=-=-=-=-

Word:	l e v i a t h a n 

Misses:	rso

YOU GOT IT!

Play "again" or "quit"? quit
```

## Exercise #9
Create a function that takes an array of names and returns an array where only the first letter of each name is capitalized.
# Examples:
```
CapMe(["mavis", "senaida", "letty"]) ➞ ["Mavis", "Senaida", "Letty"]

CapMe(["samuel", "MABELLE", "letitia", "meridith"]) ➞ ["Samuel", "Mabelle", "Letitia", "Meridith"]

CapMe(["Slyvia", "Kristal", "Sharilyn", "Calista"]) ➞ ["Slyvia", "Kristal", "Sharilyn", "Calista"]
```
Hints:
- Don't change the order of the original array.
- Notice in the second example above, "MABELLE" is returned as "Mabelle".

## Exercise #10
Create a function that takes an array of positive and negative numbers. 
Return an array where the first element is the count of positive numbers and the second element is the sum of negative numbers.

# Examples
```
CountPosSumNeg([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]) ➞ [10, -65]
// There are a total of 10 positive numbers.
// The sum of all negative numbers equals -65.

CountPosSumNeg([92, 6, 73, -77, 81, -90, 99, 8, -85, 34]) ➞ [7, -252]

CountPosSumNeg([91, -4, 80, -73, -28]) ➞ [2, -105]

CountPosSumNeg([]) ➞ []
```
# Hints:
- If given an empty array, return an empty array: []
- Cast sum to int, don't mind the remaining decimal places.
- 0 is not positive.

## Exercise #11
You need to find the word "Nemo", and return a string like this: "I found Nemo at [the order of the word you find Nemo]!".
If you can't find Nemo, return "I can't find Nemo :(".

# Examples: 
```
FindNemo("I am finding Nemo !") ➞ "I found Nemo at 4!"

FindNemo("Nemo is me") ➞ "I found Nemo at 1!"

FindNemo("I Nemo am") ➞ "I found Nemo at 2!"
```
# Hints:
 - ! , ? . are always separated from the last word.
 - Nemo will always look like Nemo, and not NeMo or other capital variations.
 - Nemo's, or anything that says Nemo with something behind it, doesn't count as Finding Nemo.
 - If there are multiple Nemo's in the sentence, only return the first one.