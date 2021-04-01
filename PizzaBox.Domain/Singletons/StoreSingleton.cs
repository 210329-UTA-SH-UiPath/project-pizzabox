using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Singletons
{
  public class StoreSingleton
  {
    private static StoreSingleton _instance;
    public List<AStore> Stores { get; set; }
    public static StoreSingleton Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new StoreSingleton();
        }

        return _instance;
      }
    }

    private StoreSingleton()
    {
      Stores = new List<AStore>()
      {
        new NewYorkStore(),
        new ChicagoStore()
      };
    }

    // public static StoreSingleton Instance()
    // {
    //   if (_instance == null)
    //   {
    //     _instance = new StoreSingleton();
    //   }

    //   return _instance;
    // }
  }
}
