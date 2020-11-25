## NET-01. Introduction and .NET Basics
### Part 08. Creating types in C# 

#### Task 01
<p align="justify">FindNthRoot algorithm calculates nth root of a real number to a specified accuracy by using Newton-Raphson method.</p> 

<p align="justify">First of all, an initial guess for a possible root is made, which is set to be a half of the input number. 
Then Newton's formula is applied repeatedly, until required accuracy is reached. To fix floating-point calculations errors, 
the final result is rounded to specified number of digits.
For some input values ArgumentOutOfRangeException is thrown, e.g. accuracy of calculation should be given as
some negative power of 10 or negative numbers have only odd-degree real roots. NUnit unit test are provided.</p>

#### Task 02
<p align="justify">
Sort method implements BubbleSort algorithm to sort integer array by aligning rows in ascending 
or descending order by sum of elements or max element or min element of each row.</p>

<p align="justify">In order to achieve cohesiveness and remove unnecessary repetition of the code, 
the Strategy pattern is used. A Matrix class is created, when instantiated, the object of such type requires an initial array,
that needs to be sorted and a sort pattern, so that user can select how this array should be sorted. 
That sort pattern is an instance of MatrixOperations abstract class, where all methods that may be used to 
perform sorting are defined. Algorithms for each sorting case are then implemented in classes that derive
from MatrixOperations class. NUnit unit tests are provided.</p>
