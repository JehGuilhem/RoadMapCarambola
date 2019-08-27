# Convert a string to an array

link:https://www.codewars.com/kata/57e76bc428d6fbc2d500036d

Write a function to split a string and convert it into an array of words. For example:

"Robin Singh" ==> ["Robin", "Singh"]

"I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
```
namespace Solution {
  using System;

  public class Solution
  {
    public static string[] StringToArray(string str)
    {
      string[] words = new string[] {""};
      return words = str.Split(' ');;
    }
  }
}
