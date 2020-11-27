using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitmentCodeFirstFromDB;

namespace RecruitmentAuthentication
{
    public static class CompanyValidation
    {
        public static bool InfoIsInvalid(this Company company)
        {
            return (company.Name == null || company.Name.Trim().Length == 0 ||
                company.HiringDepartment == null || company.HiringDepartment.Trim().Length == 0 ||
                company.HiringManager == null || company.HiringManager.Trim().Length == 0 ||
                company.Size == null || company.Size.Trim().Length == 0);
        }
    }
}
