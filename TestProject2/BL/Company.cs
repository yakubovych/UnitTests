using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject2.BL
{
  public class Company
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhysicalAddress { get; set; }
    public virtual List<User> Users { get; set; }
  }
}