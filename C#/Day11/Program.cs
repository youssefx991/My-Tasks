using L2O___D09;
using static System.Runtime.InteropServices.JavaScript.JSType;

var ProductList = ListGenerators.ProductList;
var CustomerList = ListGenerators.CustomerList;


//1.Find all products that are out of stock. 
Console.WriteLine("1.Find all products that are out of stock.");
foreach (var product in ProductList.Where(p => p.UnitsInStock <= 0))
    Console.WriteLine(product);


//2. Find all products that are in stock and cost more than 3.00 per unit. 
Console.WriteLine("\n\n2. Find all products that are in stock and cost more than 3.00 per unit.");
foreach (var product in ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3))
    Console.WriteLine(product);


//3. Returns digits whose name is shorter than their value.
Console.WriteLine("\n\n3. Returns digits whose name is shorter than their value.");
string[] Digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
foreach (var digit in Digits.Where((d, i) => d.Length < i))
    Console.WriteLine(digit);


//1. Get first Product out of Stock 
Console.WriteLine("\n\n1. Get first Product out of Stock ");
var FirstOutOfStock = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
Console.WriteLine(FirstOutOfStock == default ? "Not Found" : FirstOutOfStock);


//2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
Console.WriteLine("\n\n2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.");
var FirstPriceBiggerThan1000 = ProductList.FirstOrDefault(p => p.UnitPrice > 100);
Console.WriteLine(FirstPriceBiggerThan1000 == default ? "Not Found" : FirstPriceBiggerThan1000);


//3. Retrieve the second number greater than 5 
Console.WriteLine("\n\n3. Retrieve the second number greater than 5 ");
int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var SecondGreaterThan5 = Numbers.Where(n => n > 5).ElementAtOrDefault(1);
Console.WriteLine(SecondGreaterThan5 == default ? "Not Found" : SecondGreaterThan5);


//1. Sort a list of products by name
Console.WriteLine("\n\n1. Sort a list of products by name");
var SortedProductsByName = ProductList.OrderBy(p => p.ProductName);
foreach (var product in SortedProductsByName)
    Console.WriteLine(product);

//2.Uses a custom comparer to do a case-insensitive sort of the words in an array.
Console.WriteLine("\n\n2. Uses a custom comparer to do a case-insensitive sort of the words in an array.");
string[] Fruits = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

var SortedFruitsCaseInsensitive = Fruits.OrderBy(f => f, new FuitsCaseInsensitiveComparer());
foreach (var fruit in SortedFruitsCaseInsensitive)
    Console.WriteLine(fruit);




// 3.Sort a list of products by units in stock from highest to lowest.
Console.WriteLine("\n\n3. Sort a list of products by units in stock from highest to lowest.");
foreach (var product in ProductList.OrderByDescending(p => p.UnitsInStock))
    Console.WriteLine(product);


//4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
Console.WriteLine("\n\n4. Sort a list of digits, first by length of their name, and then alphabetically by the name \r\nitself.");
//string[] Digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
foreach (var digit in Digits.OrderBy(d => d.Length).ThenBy(d => d))
    Console.WriteLine(digit);

//5. Sort first by word length and then by a case-insensitive sort of the words in an array.
Console.WriteLine("\n\n5. Sort first by word length and then by a case-insensitive sort of the words in an array.");
//string[] fruits = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
foreach (var fruit in Fruits.OrderBy(f => f.Length).ThenBy(f => f, new FuitsCaseInsensitiveComparer()))
    Console.WriteLine(fruit);



//6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
Console.WriteLine("\n\n6. Sort a list of products, first by category, and then by unit price, from highest to lowest.");
foreach (var product in ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice))
    Console.WriteLine(product);


//7.Sort first by word length and then by a case-insensitive descending sort of the words in an array. 
//string[] Fruits = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" }
Console.WriteLine("\n\n7.Sort first by word length and then by a case-insensitive descending sort of the words in an array.");
foreach (var fruit in Fruits.OrderBy(f => f.Length).ThenByDescending(f => f, new FuitsCaseInsensitiveComparer()))
    Console.WriteLine(fruit);


//8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array. 
//string[] Digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }
Console.WriteLine("\n\n8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.");
foreach (var digit in Digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse())
    Console.WriteLine(digit);



//1. Return a sequence of just the names of a list of products.
Console.WriteLine("\n\n1. Return a sequence of just the names of a list of products.");
foreach (var product in ProductList.Select(p => p.ProductName))
    Console.WriteLine(product);

//2.Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types). 
Console.WriteLine("\n\n2.Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).");
string[] Words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
foreach (var word in Words.Select(w => new { Uppercase = w.ToUpper(), Lowercase = w.ToLower() }))
    Console.WriteLine($"{word.Uppercase} \t {word.Lowercase}");


//3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
Console.WriteLine("\n\n3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.");
foreach (var product in ProductList.Select(p => new { Name = p.ProductName, UnitPrice = p.UnitPrice }))
    Console.WriteLine($"{product.Name} \t {product.UnitPrice}");


//4. Determine if the value of ints in an array match their position in the array.
Console.WriteLine("\n\n4. Determine if the value of ints in an array match their position in the array.");
//int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
Console.WriteLine("Number : In-Place?");
foreach (var num in Numbers.Select((n, i) => new { Value = n, InPlace = (n == i) }))
    Console.WriteLine($"{num.Value} : {num.InPlace}");


//5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB. 
Console.WriteLine("5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.");
int[] NumbersA = { 0, 2, 4, 5, 6, 8, 9 };
int[] NumbersB = { 1, 3, 5, 7, 8 };

var Result = from a in NumbersA
             from b in NumbersB
             where a < b
             select $"{a} is less than {b}";
Console.WriteLine("Pairs where a < b:");
foreach (var r in Result)
    Console.WriteLine(r);



//6.Select all orders where the order total is less than 500.00.
Console.WriteLine("\n\n6.Select all orders where the order total is less than 500.00.");
var OrdersWithTotalLessThan500 = from c in CustomerList
                                 from o in c.Orders
                                 where o.Total < 500
                                 select o;
foreach (var order in OrdersWithTotalLessThan500)
    Console.WriteLine(order);

//7. Select all orders where the order was made in 1998 or later.
Console.WriteLine("\n\n7. Select all orders where the order was made in 1998 or later.");
var OrdersAfter1980 = from c in CustomerList
                      from o in c.Orders
                      where o.OrderDate.Year >= 1998
                      select o;
foreach (var order in OrdersAfter1980)
    Console.WriteLine($"{order} in {order.OrderDate.Year}");




class FuitsCaseInsensitiveComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        if (x == null) return -1;
        if (y == null) return 1;
        return x.ToLower().CompareTo(y.ToLower());
    }
}
