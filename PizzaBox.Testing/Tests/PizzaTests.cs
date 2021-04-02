using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  /// <summary>
  /// 
  /// </summary>
  public class PizzaTests
  {
    /// <summary>
    /// 
    /// </summary>
    [Fact]
    public void Test_PizzaCrust()
    {
      // arrange
      var sut = new VeganPizza();

      // act
      var actual = sut.Crust;

      // assert
      Assert.Null(actual);
    }
  }
}
