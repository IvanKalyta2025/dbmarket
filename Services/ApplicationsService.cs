using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dbmarket.Models;
using dbmarket.Data;

namespace dbmarket.Services
{
    public static class ApplicationsService
    {
        public static Applicants? FindById(int id)
        {
            return ApplicantsDatabase.ApplicantsList.FirstOrDefault(a => a.Id == id);
        }

    }
}