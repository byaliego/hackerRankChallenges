# Objective

Today, we’re delving into Inheritance. 

# Task

You are given two classes, Person and Student, where Person is the base class and Student is the derived class. Completed code for Person and a declaration for Student are provided for you in the editor. Observe that Student inherits all the properties of Person.

Complete the Student class by writing the following:

A Student class constructor, which has 4 parameters:
A string, firstName.
A string, lastName.
An integer, idNumber.
An integer array (or vector) of test scores, scores.
A char calculate() method that calculates a Student object’s average and returns the grade character representative of their calculated average:
# Input Format

The locked stub code in the editor reads the input and calls the Student class constructor with the necessary arguments. It also calls the calculate method which takes no arguments.

The first line contains firstname, lastName, and idNumber, separated by a space. The second line contains the number of test scores. The third line of space-separated integers describes scores.


 
# Constraints

1 <= length of firstName, length of lastName <= 10
length of idNumber = 7
0 <= score <= 100
# Output Format

Output is handled by the locked stub code. Your output will be correct if your Student class constructor and calculate() method are properly implemented.

## Sample Input

`Heraldo Memelli 8135627`</br>
`2`</br>
`100 80`

## Sample Output

` Name: Memelli, Heraldo`</br>
 `ID: 8135627`</br>
 `Grade: O`
