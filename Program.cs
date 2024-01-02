// See https://aka.ms/new-console-template for more information
using Imms;
Console.WriteLine("Hello, World!");
var x = ImmList.Of(1, 2, 3);
Console.WriteLine(String.Join(", ", x.AddLast(5)));