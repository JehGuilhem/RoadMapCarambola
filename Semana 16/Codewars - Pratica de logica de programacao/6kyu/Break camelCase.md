# Break camelCase

link: https://www.codewars.com/kata/5208f99aee097e6552000148

Complete the solution so that the function will break up camel casing, using a space between words.

```
using System;
using System.Collections.Generic;

public class Kata
{
  public static string BreakCamelCase(string str)
  {
    var items = new List<char>();

     for (var i= 0; i < str.Length; i++)
     {
        if (char.IsUpper(str[i]))
        {
            items.Add(' ');
        }
        items.Add(str[i]);
     }
     return string.Join("", items);
  }
}