// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program {
    static void Main(string[] args) {
  Console.WriteLine("Put two numbers");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a>b){
  Console.WriteLine("a more then b");
}
else if (a<b)
{
  Console.WriteLine("b more then a");
  }
else
{
  Console.WriteLine("a and b the same");
}
}  
}

