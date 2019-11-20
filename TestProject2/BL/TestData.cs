using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject2.BL
{
  public static class TestData
  {
    public static List<User> LocalUsers1 = new List<User>
    {
      new User{Id = 1, UserName = "test1", CreatedAt = DateTime.UtcNow, CompanyId = 2, ContactId = 2},
      new User{Id = 2, UserName = "test2", CreatedAt = DateTime.UtcNow, CompanyId = 1, ContactId = 1},
      new User{Id = 3, UserName = "test3", CreatedAt = DateTime.UtcNow, CompanyId = 1, ContactId = 6},

    };

    public static List<User> LocalUsers2 = new List<User>
    {
      new User{Id = 4, UserName = "test4", CreatedAt = DateTime.UtcNow, CompanyId = 1, ContactId = 3},
      new User{Id = 5, UserName = "test5", CreatedAt = DateTime.UtcNow, CompanyId = 2, ContactId = 5},
      new User{Id = 6, UserName = "test6", CreatedAt = DateTime.UtcNow, CompanyId = 1, ContactId = 4},
    };

    public static List<Company> LocalCompanies = new List<Company>
    {
      new Company {Id = 1, Name = "Company Name 1", PhysicalAddress = "qwerty1", Users = LocalUsers1},
      new Company {Id = 2, Name = "Company Name 2", PhysicalAddress = "qwerty2", Users = LocalUsers2}
    };

    public static List<ContactDetail> LocalContactDetails = new List<ContactDetail>
    {
      new ContactDetail { Id = 1, Home ="1", Email="1@email.com", Mobile ="12", Address1="adr1"},
      new ContactDetail { Id = 2, Home ="112", Email="fg1fdsa@email.com", Mobile ="123", Address1="adr2d"},
      new ContactDetail { Id = 3, Home ="3", Email="3@email.com", Mobile ="4712", Address1="adrsdf1"},
      new ContactDetail { Id = 4, Home ="4", Email="11431@email.com", Mobile ="912", Address1="adsar1"},
      new ContactDetail { Id = 5, Home ="5", Email="1s3@email.com", Mobile ="1218", Address1="12sdadr1"},
      new ContactDetail { Id = 6, Home ="6", Email="1314tgf@email.com", Mobile ="1221", Address1="asdfdr1"}
    };
  }
}