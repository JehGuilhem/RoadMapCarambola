# Multiples of 3 or 5

link: https://www.codewars.com/kata/514b92a657cdc65150000006

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

```
public static class Kata
{
  public static int Solution(int value)
  {
    int result = 0;
    for (int i = 0; i < value; i++){
      if(i % 3 == 0 || i % 5 == 0){
       result += i;
      }
    }
    return result;
  }
}
