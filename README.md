In this task, I compared strings with each other in CheckPermutation(string firstWord, string secondWord) method by converting strings to "char : occurence" key value pair:
e.g:
"baba" = { "b":2, "a":2 }
"abc" = { "a": 1, "b": 1, "c": 1 }

And then checking two things for each chars and applying the following points with AND operator:
1. is occurence count of a char in first word lower than the occurrence count of exact same char in the second char
2. all chars in first word also exists in the second word.


e.g-1.1:
"baba" | "abc"
"b": 2 | "b": 1
"a": 2 | "a": 1
"c": 0 | "c": 1 

for e.g-1.1:
    for firstWord = "baba" and secondWord = "abc", condition x is false:
        x.1 = First point returns false as occurence counts of chars in first word are greater than the count of exact same chars.
        x.2 = Second point returns true as all unique chars in first word exists in second word.
        We apply logical AND (indirectly) operator to first and second point here and this returns false.
        x = (x.1 && x.2) = FALSE

    for firstWord = "abc" and secondWord = "baba", conition y is false:
        y.1 = First point returns true as occurence counts of chars in first word are lower than the count of exact same chars.
        y.2 = Second point returns false as "c" char doesn't exist in "baba"
        Again, we apply logical AND operator here and it returns false
        y = (y.1 && y.2) = FALSE

We check both conditions with an OR operator:
    x || y = false

e.g-1.2:
"lds"  | "loodos"
"l": 1 | "l": 1
"d": 1 | "d": 1
"s": 1 | "s": 1
"o": 0 | "o": 3

for e.g-1.2:
    for firstWord = "lds" and secondWord = "loodos", condition x is true:
        x.1 = First point returns true as occurence counts of chars in first word are lower than the count of exact same chars.
        x.2 = Second point returns true as all unique chars in first word exists in second word.
        We apply logical AND (indirectly) operator to first and second point here and this returns TRUE.
        x = (x.1 && x.2) = TRUE

    for firstWord = "loodos" and secondWord = "lds" it returns false:
        y.1 = First point returns false as occurence counts of chars in first word are greater than the count of exact same chars.
        y.2 = Second point returns false as "o" char doesn't exist in "lds"
        Again, we apply logical AND operator here and it returns TRUE.
        y = (y.1 && y.2) = FALSE

We check both conditions with an OR operator:
    x || y = TRUE
