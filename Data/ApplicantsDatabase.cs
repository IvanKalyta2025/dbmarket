using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dbmarket.Data
{
    public static class ApplicantsDatabase
    {
        public static List<Models.Applicants> ApplicantsList =
        [
            new Models.Applicants(32, "John", "Doe", 30, "123 Main St", "Experienced software developer."),
            new Models.Applicants(33, "Jane", "Smith", 25, "456 Oak Ave", "Recent graduate looking for opportunities."),
            new Models.Applicants(34, "Alice", "Johnson", 28, "789 Pine Rd", "Marketing specialist with 5 years of experience."),
            new Models.Applicants(35, "Bob", "Brown", 35, "321 Maple St", "Project manager in the construction industry."),
            new Models.Applicants(36, "Eve", "Davis", 22, "654 Cedar Blvd", "Graphic designer and illustrator.")
        ];

    }
}