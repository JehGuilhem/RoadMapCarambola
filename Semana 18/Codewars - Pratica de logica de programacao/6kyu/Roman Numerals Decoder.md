# Roman Numerals Decoder

link: https://www.codewars.com/kata/51b6249c4612257ac0000005

Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer. You don't need to validate the form of the Roman numeral.

Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s. So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.

```
using System;
using System.Linq;
using System.Collections.Generic;


public class RomanDecode
{
	public static int Solution(string roman)
	{
		Dictionary<int, string> seq = new Dictionary<int, string>
        { { 1000, "M" },  { 900, "CM" },  { 500, "D" },  { 400, "CD" },  { 100, "C" },
                          { 90 , "XC" },  { 50 , "L" },  { 40 , "XL" },  { 10 , "X" },
                          { 9  , "IX" },  { 5  , "V" },  { 4  , "IV" },  { 1  , "I" } };
     return roman.Length == 0 ? 0 : seq.Where(x => roman.StartsWith(x.Value)).Select(x => x.Key 
             + Solution(roman.Substring(x.Value.Length))).FirstOrDefault();
	}
}