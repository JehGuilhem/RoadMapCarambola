# Valid Braces

link: https://www.codewars.com/kata/5277c8a221e209d3f6000b56

Write a function that takes a string of braces, and determines if the order of the braces is valid. It should return true if the string is valid, and false if it's invalid.

This Kata is similar to the Valid Parentheses Kata, but introduces new characters: brackets [], and curly braces {}. Thanks to @arnedag for the idea!

All input strings will be nonempty, and will only consist of parentheses, brackets and curly braces: ()[]{}.

What is considered Valid?

```
using System.Collections.Generic;

public class Brace {
  public static bool validBraces(string braces) {
    
    var st = new Stack<char>();
    
    foreach (var c in braces)
      switch (c)
      {
        case '(':
        case '[':
        case '{':
          st.Push(c);
          continue;
        case ')':
          if (st.Count == 0 || st.Pop() != '(') return false;
          continue;
        case ']':
          if (st.Count == 0 || st.Pop() != '[') return false;
          continue;
        case '}':
          if (st.Count == 0 || st.Pop() != '{') return false;
          continue;
      }
    return st.Count == 0;
  }
}