# Persistent Bugger.

link: https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec

Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

```
using System;

public class Persist 
{
  public static int Persistence(long n) 
  {
    int count = 0;
    long product = 1;
    
    if(n/10==0) return 0;
    
    while(true)
    {
      while(n!=0)
      {
        product*=n%10;
        n/=10;
        
      }
      count++;
      
      if(product/10==0) return count;
      else 
      {
        n = product;
        product = 1;
      }
    }
  }
}