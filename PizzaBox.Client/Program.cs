using System;
using System.Collections.Generic;

namespace PizzaBox.Client
{
  internal class Program // access modifiers = internal, protected, private, public
  {
    private static void Main(string[] args)
    {
      Program.Run();
    }

    private static void Run() // modifiers (extended) = static vs const vs readonly
    {
      System.Console.WriteLine("Welcome to PizzaBox");

      var stores = new List<string>()
      {
        "Store 001",
        "Store 002",
        "Store 003"
      };

      foreach (var item in stores)
      {
        System.Console.WriteLine(item);
      }
    }
  }
}
