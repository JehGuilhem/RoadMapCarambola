# Who likes it?

link: https://www.codewars.com/kata/5266876b8f4bf2da9b000362

You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item. It must return the display text as shown in the examples:
```
using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    switch(name.Length) {
      case 0: 
        return "no one likes this";  
      case 1: 
        return name[0] + " likes this"; 
      case 2: 
        return name[0] + " and " + name[1] + " like this";
      case 3:
        return name[0] + ", " + name[1] + " and " + name[2] + " like this";
      default:
        return name[0] + ", " + name[1] + " and " + (name.Length - 2) + " others like this";
    }
  }  
}```
