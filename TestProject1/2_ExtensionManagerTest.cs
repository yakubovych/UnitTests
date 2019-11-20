using NUnit.Framework;
using Moq;
using TestProject1.Mock;

namespace TestProject1
{
  public class ExtensionManagerTests
  {
    [Test]
    public void Stub_Extension_Manager_Returns_True()
    {
      //Arrange
      StubExtensionManager stub = new StubExtensionManager();
      FileChecker checker = new FileChecker(stub);

      //Act
      bool IsTrueFile = checker.CheckFile("myFile.exe");

      //Assert
      Assert.IsTrue(IsTrueFile);
      Assert.AreEqual(true, IsTrueFile);
    }

    [Test]
    public void Mock_Extension_Manager_Returns_Wrong_Type()
    {
      //Arrange
      var mockobject = new MockExtensionService();
      //var mock = new Mock<IServiceProvider>();

      //Inject mock object
      var analyzer = new ExtensionAnalyzer(mockobject);
      //var analyzer1 = new ExtensionAnalyzer(mock.Object);
      //mock.Setup(x => x.extensionService(It.IsAny<string>())).Returns("Wrong Type");

      //Act
      var actualResult = analyzer.ExtensionCheck("file.txt");
      //var actualResult1 = analyzer1.ExtensionCheck("");

      //Assert  
      Assert.AreEqual("Wrong Type", actualResult);
      //Assert.AreEqual("Wrong Type", actualResult1);
    }
  }
}