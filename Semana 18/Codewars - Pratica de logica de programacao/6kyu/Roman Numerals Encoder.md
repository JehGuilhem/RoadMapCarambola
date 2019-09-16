# Roman Numerals Encoder

link: https://www.codewars.com/kata/51b62bf6a9c58071c600001b

Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.

Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.
```
using System;

public class RomanConvert
{
	public static string Solution(int n)
	{
		int[] seqD = {1000, 900, 500,400,100,90,50,40,10,9,5,4,1};
   string[] seqC = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
   int i = 0;  
   string s = "";
      while (n > 0)              
        {
         if (seqD[i] <= n)
           {
             n = n - seqD[i];   
             s = s + seqC[i]; 
           }
          else i++;
         }
        return s;
	}
}