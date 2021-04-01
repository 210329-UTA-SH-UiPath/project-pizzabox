using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Singletons;

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

      var storeSingleton = StoreSingleton.Instance;

      foreach (var item in storeSingleton.Stores)
      {
        System.Console.WriteLine(item);
      }

      storeSingleton.WriteToFile();
    }
  }
}
