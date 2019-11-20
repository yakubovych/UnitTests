using System;

namespace TestProject1.Mock
{
  public interface IServiceProvider
  {
    string extensionService(string fileName);
  }

  //Mock extenison service provider  
  public class MockExtensionService : IServiceProvider
  {
    public string extensionService(string fileName)
    {
      if (fileName.Split('.')[1] != "cfg")
      {
        return "Wrong Type";
      }

      return string.Empty;
    }
  }

  //Actual incomplete ExtensionManager functionality  
  public class ExtensionManager : IServiceProvider
  {
    public string extensionService(string fileName)
    {
      throw new NotImplementedException();
    }
  }

  public class ExtensionAnalyzer
  {
    public IServiceProvider provider = null;
    public ExtensionAnalyzer(IServiceProvider tmpProvider)
    {
      provider = tmpProvider;
    }

    public string ExtensionCheck(string fileName)
    {
      return provider.extensionService(fileName);
    }
  }
}