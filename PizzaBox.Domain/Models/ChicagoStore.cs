using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class ChicagoStore : AStore
  {
    /// <summary>
    /// 
    /// </summary>
    public ChicagoStore()
    {
      Name = "ChicagoStore";
    }

    public override string ToString()
    {
      return $"This is Chitown - {Name}";
    }
  }
}
