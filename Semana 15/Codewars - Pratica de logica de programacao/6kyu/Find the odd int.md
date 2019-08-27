# Find the odd int

link:https://www.codewars.com/kata/54da5a58ea159efa38000836

Given an array, find the int that appears an odd number of times.

There will always be only one integer that appears an odd number of times.
'''
using System;
using System.Collections.Generic;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        Dictionary<int, int> numeros = new Dictionary<int, int>();
      
        for (int i = 0; i < seq.Length; i++)
        {
          if (numeros.ContainsKey(seq[i]) == true)
          {
            numeros[seq[i]] += 1;
          } else numeros [seq[i]] = 1;
        }  
        foreach (KeyValuePair <int, int> entrada in numeros)
        {
          if (entrada.Value % 2 != 0)
          {
            return entrada.Key;
          }
        }        
        return -1;
      }
       
    }
}'''
