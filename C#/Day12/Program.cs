using L2O___D09;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

var ProductList = ListGenerators.ProductList;
var CustomerList = ListGenerators.CustomerList;

string[] Digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
string[] Fruits = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
string[] Words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
int[] NumbersA = { 0, 2, 4, 5, 6, 8, 9 };
int[] NumbersB = { 1, 3, 5, 7, 8 };
string[] DictionaryEnglish = File.ReadAllLines("dictionary_english.txt");
string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };


//1. Find the unique Category names from Product List
Console.WriteLine("1. Find the unique Category names from Product List");
foreach (var product in ProductList.Select(p => p.ProductName).Distinct())
    Console.WriteLine(product);

//2. Produce a Sequence containing the unique first letter from both product and customer names.
Console.WriteLine("\n\n2. Produce a Sequence containing the unique first letter from both product and customer names.");
var ProductNameFirstLetter = ProductList.Select(p => p.ProductName.ElementAtOrDefault(0));
var CustomerNameFirsLetter = CustomerList.Select(c => c.CompanyName.ElementAtOrDefault(0));

foreach (var item in ProductNameFirstLetter.Union(CustomerNameFirsLetter))
    Console.WriteLine(item);


//3. Create one sequence that contains the common first letter from both product and customer names. 
Console.WriteLine("\n\n3. Create one sequence that contains the common first letter from both product and customer names. ");
//var ProductNameFirstLetter = ProductList.Select(p => p.ProductName.ElementAtOrDefault(0));
//var CustomerNameFirsLetter = CustomerList.Select(c => c.CompanyName.ElementAtOrDefault(0));

foreach (var item in ProductNameFirstLetter.Intersect(CustomerNameFirsLetter))
    Console.WriteLine(item);


//4. Create one sequence that contains the first letters of product names that are not also first letters of customer names. 
Console.WriteLine("\n\n4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.");
//var ProductNameFirstLetter = ProductList.Select(p => p.ProductName.ElementAtOrDefault(0));
//var CustomerNameFirsLetter = CustomerList.Select(c => c.CompanyName.ElementAtOrDefault(0));

foreach (var item in ProductNameFirstLetter.Except(CustomerNameFirsLetter))
    Console.WriteLine(item);


//5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
Console.WriteLine("\n\n5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates");
var ProductNameLastThreeLetters = ProductList.Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3, 3) : p.ProductName);
var CustomerNameLastThreeLetters = CustomerList.Select(c => c.CompanyName.Length >= 3 ? c.CompanyName.Substring(c.CompanyName.Length - 3, 3) : c.CompanyName);

foreach (var item in ProductNameLastThreeLetters.Union(CustomerNameLastThreeLetters))
    Console.WriteLine(item);

//1. Uses Count to get the number of odd numbers in the array 
//int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
Console.WriteLine("\n\n1. Uses Count to get the number of odd numbers in the array ");
Console.WriteLine(Numbers.Count(n => n % 2 == 1));

//2. Return a list of customers and how many orders each has.
Console.WriteLine("\n\n2. Return a list of customers and how many orders each has.");
foreach (var item in CustomerList.Select(c => new { Name = c.CompanyName, Orders = c.Orders.Length }))
    Console.WriteLine($"{item.Name} : {item.Orders}");

//3. Return a list of categories and how many products each has
Console.WriteLine("\n\n3. Return a list of categories and how many products each has");
foreach (var item in ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, Count = g.Count() }))
    Console.WriteLine($"{item.Category} : {item.Count}");

//4.Get the total of the numbers in an array. 
//int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
Console.WriteLine("\n\nGet the total of the numbers in an array");
Console.WriteLine(Numbers.Sum());


//5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
Console.WriteLine("\n\n5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");
Console.WriteLine(DictionaryEnglish.Sum(w => w.Length));

//6. Get the total units in stock for each product category.
Console.WriteLine("\n\n6. Get the total units in stock for each product category.");
foreach (var item in ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, Stock = g.Sum(p => p.UnitsInStock) }))
    Console.WriteLine($"{item.Category} : {item.Stock}");

//7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
Console.WriteLine("\n\n7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");
Console.WriteLine(DictionaryEnglish.MinBy(w => w.Length).Length);

//8. Get the cheapest price among each category's products
Console.WriteLine("\n\n8. Get the cheapest price among each category's products");
foreach (var item in ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, MinPrice = g.Min(w => w.UnitPrice) }))
    Console.WriteLine($"{item.Category} : {item.MinPrice}");

//9. Get the products with the cheapest price in each category (Use Let)
Console.WriteLine("\n\n9. Get the products with the cheapest price in each category (Use Let)");
var CheapestProductsPerCategory = from p in ProductList
                                  group p by p.Category into g
                                  let MinPrice = g.Min(p => p.UnitPrice)
                                  select new { Category = g.Key, Products = g.Where(p => p.UnitPrice == MinPrice) };
foreach (var group in CheapestProductsPerCategory)
    foreach (var product in group.Products)
        Console.WriteLine($"{group.Category} : {product}");


//10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
Console.WriteLine("\n\n10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");
Console.WriteLine(DictionaryEnglish.MaxBy(w => w.Length).Length);

//11. Get the most expensive price among each category's products.
Console.WriteLine("\n\n11. Get the most expensive price among each category's products.");
foreach (var item in ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) }))
    Console.WriteLine($"{item.Category} : {item.MaxPrice}");


//12. Get the products with the most expensive price in each category.
Console.WriteLine("\n\n12. Get the products with the most expensive price in each category.");
var HighestProductsPerCategory = from p in ProductList
                                 group p by p.Category into g
                                 let MaxPrice = g.Max(p => p.UnitPrice)
                                 select new { Category = g.Key, Products = g.Where(p => p.UnitPrice == MaxPrice) };
foreach (var group in HighestProductsPerCategory)
    foreach (var product in group.Products)
        Console.WriteLine($"{group.Category} : {product}");


//13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
Console.WriteLine("\n\n13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");
Console.WriteLine(DictionaryEnglish.Average(w => w.Length));

//14. Get the average price of each category's products. 
Console.WriteLine("\n\n14. Get the average price of each category's products. ");
foreach (var item in ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) }))
    Console.WriteLine($"{item.Category} : {item.AvgPrice}");

//1. Get the first 3 orders from customers in Washington
Console.WriteLine("\n\n1. Get the first 3 orders from customers in Washington");
foreach (var orders in CustomerList.Where(c=>c.City.ToLower()== "Washington").Take(3))
    Console.WriteLine(orders);

//2. Get all but the first 2 orders from customers in Washington.
Console.WriteLine("\n\n2. Get all but the first 2 orders from customers in Washington.");
foreach (var orders in CustomerList.Where(c => c.City.ToLower() == "Washington").Skip(2))
    Console.WriteLine(orders);


//3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array. 
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
Console.WriteLine("\n\n3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array. ");
foreach (var item in Numbers.TakeWhile((n, i) => n >= (i + 1)))
    Console.WriteLine(item);

//4. Get the elements of the array starting from the first element divisible by 3. 
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
Console.WriteLine("\n\n4. Get the elements of the array starting from the first element divisible by 3. ");
foreach (var item in Numbers.SkipWhile(n=>n%3!=0))
    Console.WriteLine(item);

//5. Get the elements of the array starting from the first element less than its position.
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
Console.WriteLine("\n\n5. Get the elements of the array starting from the first element less than its position.");
foreach (var item in Numbers.SkipWhile((n, i) => n >= (i + 1)))
    Console.WriteLine(item);


//1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'.
Console.WriteLine("\n\n1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'.");
Console.WriteLine(DictionaryEnglish.Any(w=>w.Contains("ei")));

//2. Return a grouped a list of products only for categories that have at least one product that is out of stock. 
Console.WriteLine("\n\nReturn a grouped a list of products only for categories that have at least one product that is out of stock.");
foreach (var kvp in ProductList.GroupBy(p=>p.Category).Where(g=>g.Any(p => p.UnitsInStock == 0)).ToDictionary(g=>g.Key, g=>g.Select(p=>p.ProductName)))
     foreach (var product in kvp.Value)
        Console.WriteLine($"{kvp.Key} : {product}");


//3. Return a grouped a list of products only for categories that have all of their products in stock.
Console.WriteLine("\n\n3. Return a grouped a list of products only for categories that have all of their products in stock.");
foreach (var kvp in ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0)).ToDictionary(g => g.Key, g => g.Select(p => p.ProductName)))
    foreach (var product in kvp.Value)
        Console.WriteLine($"{kvp.Key} : {product}");


//1. Use group by to partition a list of numbers by their remainder when divided by 5
//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
Console.WriteLine("\n\n1. Use group by to partition a list of numbers by their remainder when divided by 5");
foreach (var item in Numbers.GroupBy(n=>n%5))
{
    Console.WriteLine($"Numbers with remainder {item.Key} when divider by 5");
    foreach (var n in item)
        Console.WriteLine(n);
}

//2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input
Console.WriteLine("\n\n2. Uses group by to partition a list of words by their first letter.");
foreach (var item in DictionaryEnglish.GroupBy(w=>w.ElementAt(0)))
    foreach (var word in item)
    {
        //Console.WriteLine($"{item.Key} : {word}");
        //Console.WriteLine();
    }


//3. Consider this Array as an Input  
//string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
// Use Group By with a custom comparer that matches words that are consists of the same Characters Together
Console.WriteLine("\n\nUse Group By with a custom comparer that matches words that are consists of the same Characters Together");
foreach (var item in Arr.GroupBy(w=>w, new MyCustomComparer()))
    foreach (var word in item)
        Console.WriteLine($"{item.Key} : {word}");




class MyCustomComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        return GetNormalizedKey(x) == GetNormalizedKey(y);
    }

    public int GetHashCode([DisallowNull] string obj)
    {
        return GetNormalizedKey(obj).GetHashCode();
    }

    private string GetNormalizedKey(string? s)
    {
        if (string.IsNullOrWhiteSpace(s)) return string.Empty;

        char[] chars = s.Trim().ToLower().ToCharArray();

        Array.Sort(chars);

        return new string(chars);
    }
}



class FuitsCaseInsensitiveComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        if (x == null) return -1;
        if (y == null) return 1;
        return x.ToLower().CompareTo(y.ToLower());
    }
}
