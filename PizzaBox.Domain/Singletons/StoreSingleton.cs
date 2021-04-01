using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
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

    public void WriteToFile()
    {
      // access to path
      string path = @"store.xml"; // literal string
      // open file
      StreamWriter writer = new StreamWriter(path);
      // access to object
      var stores = Stores;
      // class definition (structure)
      XmlSerializer xml = new XmlSerializer(typeof(List<AStore>));
      // serialize (convert to markup) to xml
      xml.Serialize(writer, stores);
      // write to file
      // close file
    }

    public void ReadFromFile()
    {

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
