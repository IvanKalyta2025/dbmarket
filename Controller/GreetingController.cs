using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace dbmarket.Controller
{
    public class GreetingController
    {
        public static void Run(string? rawName)
        {
            string login = rawName ?? string.Empty.Trim();
            if (string.IsNullOrEmpty(login))
            {
                Console.WriteLine("You didn't provide a login.");
                return;
            }

            var applicant = Services.ApplicationsService.FindByCardNumber(int.Parse(login));
            if (applicant is null)
            {
                Console.WriteLine($"No applicant found with card number {login}.");
                return;
            }

            Console.WriteLine($"You used login, {login}!\n Details: {applicant.Id} {applicant.Name} {applicant.LastName}, Age: {applicant.Age}, Adresse: {applicant.Adresse}, Description: {applicant.Description}");
        }

    }
}