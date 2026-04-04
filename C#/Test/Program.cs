using System.IO.Pipes;

var person1 = new { name = "youssef", age = 24 };
var person2 = new { name = "wagih", age = 56 };
person1 = person2 with { age = 24 };
Console.WriteLine(person1.GetType());
Console.WriteLine(person2.GetType());
Console.WriteLine(person1.ToString());
Console.WriteLine(person2);
Console.WriteLine(person1 == person2);
Console.WriteLine(person1.Equals(person2));