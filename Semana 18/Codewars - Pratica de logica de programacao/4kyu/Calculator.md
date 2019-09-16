# Calculator

link: https://www.codewars.com/kata/5235c913397cbf2508000048

Create a simple calculator that given a string of operators (), +, -, *, / and numbers separated by spaces returns the value of that expression

	- Refatorada após ver solutions que deixam a solução menos verbosa
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

public class Evaluator
{
    public double Evaluate(string s) => Math.Round(Convert.ToDouble(new DataTable().Compute(s, String.Empty)), 6);
}