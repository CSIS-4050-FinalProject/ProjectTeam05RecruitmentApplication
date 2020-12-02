using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitmentCodeFirstFromDB;

namespace RecruitmentAuthentication
{
    public static class PerkValidation
    {
        public static bool InfoIsInvalid(this Perk perk)
        {
            return (perk.Description == null || perk.Description.Trim().Length == 0 ||
                perk.Amount == null || perk.Amount == 0 ||
                perk.AvailableAfterMonth == null || perk.AvailableAfterMonth == 0);
        }
    }
}
