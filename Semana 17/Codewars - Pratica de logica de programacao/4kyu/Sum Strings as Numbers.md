# Sum Strings as Numbers

link: https://www.codewars.com/kata/5324945e2ece5e1f32000370

Given the string representations of two integers, return the string representation of the sum of those integers.

```
using System;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {    
       string final = null;
       int plus = 0;
       int sum = 0;
       
       while (a.Length > b.Length) b = "0" + b;
            
       while (a.Length < b.Length) a = "0" + a;
            
            for (int i = a.Length - 1; i >= 0; i--)
            {
                sum = plus + Convert.ToInt32(a[i]) + Convert.ToInt32(b[i]) - 96;
                plus = 0;
                if (sum > 9)
                {
                    sum -= 10;
                    plus = 1;
                }
                final = Convert.ToString(sum) + final;
            }
            if (plus == 1) final = "1" + final;
            
            while (final[0] == '0') final = final.Substring(1);
            
            return final;    
    }
}