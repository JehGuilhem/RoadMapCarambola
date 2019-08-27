# Build Tower

link: https://www.codewars.com/kata/576757b1df89ecf5bd00073b

Build Tower by the following given argument:
number of floors (integer and always greater than 0).

Tower block is represented as *

Python: return a list;
JavaScript: returns an Array;
C#: returns a string[];
PHP: returns an array;
C++: returns a vector<string>;
Haskell: returns a [String];
Ruby: returns an Array;

'''
public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    string[] result = new string [nFloors];
    int altura = (nFloors - 1) * 2 + 1;
    for (int i = 0; i < nFloors; i++)
    {
      int escadas = i * 2 + 1;
      int intervalo = (altura - escadas) / 2;
      
      string espaco = "";
      for (int j = 0; j < intervalo; j++) { espaco += " "; }
      for (int j = 0; j < escadas; j++) { espaco += "*"; }
      for (int j = 0; j< intervalo; j++) {espaco += " ";}
      result[i] = espaco;
    }
    return result;
  }
}
'''
