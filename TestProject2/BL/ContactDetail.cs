using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject2.BL
{
  public class ContactDetail
  {
    public int Id { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Home { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public virtual int UserId { get; set; }
  }
}