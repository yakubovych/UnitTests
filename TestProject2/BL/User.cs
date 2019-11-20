using System;

namespace TestProject2.BL
{
  public class User
  {
    public int Id { get; set; }
    public string UserName { get; set; }
    public DateTime CreatedAt { get; set; }
    public virtual int CompanyId { get; set; }
    public virtual int ContactId { get; set; }
    public virtual Company Company { get; set; }
    public virtual ContactDetail Contact { get; set; }
  }
}