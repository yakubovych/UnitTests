using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject2.BL
{
  public interface IUserRepository
  {
    User GetUserInfo(int userId);
    Company GetUserCompany(int companyId);
    ContactDetail GetUserContactDetails(int contactId);
  }
}
