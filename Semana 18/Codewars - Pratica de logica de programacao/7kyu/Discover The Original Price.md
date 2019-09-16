# Discover The Original Price

link: https://www.codewars.com/kata/552564a82142d701f5001228

We need to write some code to return the original price of a product, the return type must be of type decimal and the number must be rounded to two decimal places.

We will be given the sale price (discounted price), and the sale percentage, our job is to figure out the original price.

```
using System;

public static class Kata
{
    public static decimal DiscoverOriginalPrice(decimal discountedPrice, decimal salePercentage)
    {
        return Math.Round(discountedPrice / (1 - salePercentage / 100) * 100) / 100;
    }
}