using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  /// <summary>
  /// 
  /// </summary>
  public class StoreTests
  {
    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_StoreName()
    {
      // arrange
      var sut = new ChicagoStore();

      // act
      var actual = sut.Name;

      // assert
      Assert.True(actual == "ChicagoStore");
    }
  }
}
