# Fruit Machine

link: https://www.codewars.com/kata/590adadea658017d90000039

Slot machine (American English), informally fruit machine (British English), puggy (Scottish English slang), the slots (Canadian and American English), poker machine (or pokies in slang) (Australian English and New Zealand English) or simply slot (American English), is a casino gambling machine with three or more reels which spin when a button is pushed. Slot machines are also known as one-armed bandits because they were originally operated by one lever on the side of the machine as distinct from a button on the front panel, and because of their ability to leave the player in debt and impoverished. Many modern machines are still equipped with a legacy lever in addition to the button.

```
using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class Kata
    {
        public int fruit(List<string[]> reels, int[] spins)
        {
           string[] reel = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack"};
           string[] items = new string[] { reels[0][spins[0]], reels[1][spins[1]], reels[2][spins[2]] };
           
           if (items[0] == items[1] && items[0] == items[2])
            {
               return (10 - Array.IndexOf(reel, items[0])) * 10;
            }
            
            string item = "";
            string extra = "";
            
            if (items[0] == items[1]) 
              { 
                item = items[0]; extra = items[2]; 
              }
            if (items[0] == items[2]) 
              { 
                item = items[0]; extra = items[1]; 
              }
            if (items[1] == items[2]) 
              { 
                item = items[1]; extra = items[0]; 
              }
            if (item != "")
            {
                int num = 10 - Array.IndexOf(reel, item);
                if (extra == "Wild") { num = num * 2; }
                return num;
            }
            return 0;
        }
    }
}