# Valid Parentheses

link: https://www.codewars.com/kata/52774a314c2333f0a7000688

Write a function called that takes a string of parentheses, and determines if the order of the parentheses is valid. The function should return true if the string is valid, and false if it's invalid.

```
using System;
using System.Linq;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
    if (input == "" || input == String.Empty) return true;
        var arr = input.Where(x => x == 40 || x == 41).ToArray();
        return arr.First() != 40 || arr.Last() == 40 || arr.Count() % 2 != 0  ? false : true;
       
    }
}