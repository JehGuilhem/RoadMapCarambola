# Find numbers which are divisible by given number

link: https://www.codewars.com/kata/55edaba99da3a9c84000003b

Complete the function which takes two arguments and returns all numbers which are divisible by the given divisor. First argument is an array of numbers and the second is the divisor.
```
using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] DivisibleBy(int[] numbers, int divisor)
  {
    List<int> divisibles = new List<int>();
    
    for(int i = 0; i < numbers.Length; i++)
      if (numbers[i] % divisor == 0) divisibles.Add(numbers[i]); 
        
    return divisibles.ToArray();
  }
}




