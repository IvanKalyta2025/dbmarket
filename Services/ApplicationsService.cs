using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dbmarket.Models;
using dbmarket.Data;
using Microsoft.VisualBasic;

namespace dbmarket.Services
{
    public static class ApplicationsService
    {
        public static Applicants? FindByCardNumber(int cardnumber)
        {
            return ApplicantsDatabase.ApplicantsList.FirstOrDefault(applicant => applicant.CardNumber == cardnumber);
        }
    }
}