using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Singletons
{
  /// <summary>
  /// 
  /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
    private StoreSingleton()
    {
      Stores = new List<AStore>()
      {
        new NewYorkStore(),
        new ChicagoStore()
      };
    }

    /// <summary>
    /// 
    /// </summary>
    public void WriteToFile()
    {
      var path = @"store.xml";
      var writer = new StreamWriter(path);
      var stores = Stores;
      var xml = new XmlSerializer(typeof(List<AStore>));

      xml.Serialize(writer, stores);
    }

    /// <summary>
    /// 
    /// </summary>
    public void ReadFromFile()
    {

    }
  }
}
