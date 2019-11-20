using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
  public interface IExtensionNanager
  {
    Boolean CheckExtension(string FileName);
  }

  public class ExtensionManager : IExtensionNanager
  {
    public bool CheckExtension(string FileName)
    {
      //Some complex business logic might goes here. May be DB operation or file system handling
      return false;
    }
  }

  //Stub implementation to bypass actual Extension manager class.
  public class StubExtensionManager : IExtensionNanager
  {
    public bool CheckExtension(string FileName)
    {
      return true;
    }
  }

  public class FileChecker
  {
    IExtensionNanager objmanager = null;
    //Default constructor  
    public FileChecker()
    {
      objmanager = new ExtensionManager();
    }
    //parameterized constructor  
    public FileChecker(IExtensionNanager tmpManager)
    {
      objmanager = tmpManager;
    }

    public Boolean CheckFile(String FileName)
    {
      return objmanager.CheckExtension(FileName);
    }
  }
}