using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing.Repositories
{
  public class FileRepository
  {
    public bool WriteToFile(List<AStore> stores)
    {
      try
      {
        var path = @"store.xml";
        var writer = new StreamWriter(path);
        var xml = new XmlSerializer(typeof(List<AStore>));

        xml.Serialize(writer, stores);

        return true;
      }
      // catch (FileNotFoundException e)
      // {
      //   throw new Exception("you have wrong file", e);
      // }
      catch
      {
        return false;
      }
    }

    public List<AStore> ReadFromFile()
    {
      var path = @"store.xml";
      var reader = new StreamReader(path);
      var xml = new XmlSerializer(typeof(List<AStore>)); // POCO = plain old csharp object

      return xml.Deserialize(reader) as List<AStore>; // if error => null
      // return (List<AStore>) xml.Deserialize(reader); // if error => exception
    }
  }
}
