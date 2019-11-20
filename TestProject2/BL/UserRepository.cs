using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject2.BL
{
  public class UserRepository : IUserRepository
  {
    public User GetUserInfo(int userId)
    {
      var users = TestData.LocalUsers1.Concat(TestData.LocalUsers2);
      var user = users.FirstOrDefault(x => x.Id == userId);
      user.Company = GetUserCompany(user.CompanyId);
      user.Contact = GetUserContactDetails(user.ContactId);

      return user;
    }

    public Company GetUserCompany(int companyId)
    {
      return TestData.LocalCompanies.FirstOrDefault(x => x.Id == companyId);
    }

    public ContactDetail GetUserContactDetails(int contactId)
    {
      return TestData.LocalContactDetails.FirstOrDefault(x => x.Id == contactId);
    }
  }
}