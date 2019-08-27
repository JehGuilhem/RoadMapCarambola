# Are the numbers in order?

Link: https://www.codewars.com/kata/56b7f2f3f18876033f000307

Are the numbers in order?
In this Kata, your function receives an array of integers as input. Your task is to determine whether the numbers are in ascending order. An array is said to be in ascending order if there are no two adjacent integers where the left integer exceeds the right integer in value.

For the purposes of this Kata, you may assume that all inputs are valid, i.e. non-empty arrays containing only integers.

Note that an array of 1 integer is automatically considered to be sorted in ascending order since all (zero) adjacent pairs of integers satisfy the condition that the left integer does not exceed the right integer in value. An empty list is considered a degenerate case and therefore will not be tested in this Kata - feel free to raise an Issue if you see such a list being tested.
```
using System;

public class Kata
{
  public static bool IsAscOrder(int[] arr)
  { 
    for (int i = 0; i < arr.Length-1; i++)
    {
      if (arr[i] > arr[i+1]) return false;
    }
    return true;
  }
}
