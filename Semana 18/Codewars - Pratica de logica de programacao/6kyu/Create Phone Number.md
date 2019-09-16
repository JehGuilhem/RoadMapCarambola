# Create Phone Number

link: https://www.codewars.com/kata/52774a314c2333f0a7000688

Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.

	- 1° Solução
```
public class Kata
{
  public static string CreatePhoneNumber(int[] n) 
  {
    return "(" + n[0] + n[1] + n[2] + ") " + n[3] + n[4] + n[5] + "-" + n[6] + n[7] + n[8] + n[9];
  }
}´´´

	- 2° Solução com Linq
```
public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select(x => x.ToString()).ToArray());
  }
}´´´