using NUnit.Framework;

namespace TestProject1
{
  [TestFixture]
  public class SimpleCalculatorTest
  {
    [TestCase(1, 2)]
    [TestCase(2, 1)]
    public void Check_Sum(int a, int b)
    {
      // Assert
      Assert.AreEqual(3, a + b);
    }
    
    [Test]
    public void Verify_Aggregation()
    {
      // Arrange
      int a = 2, b = 1;

      // Assert
      Assert.AreEqual(3, a + b);
    }
  }
}