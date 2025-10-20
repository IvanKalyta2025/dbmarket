using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing.Matching;

namespace dbmarket.Models
{
    public class Applicants
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Adresse { get; set; }
        public string? Description { get; set; }

        public Applicants(string? name, string? lastname, int age, string? adresse, string? description)
        {
            Id = new Random().Next(1, 1000);
            Name = name;
            LastName = lastname;
            Age = age;
            Adresse = adresse;
            Description = description;
        }
    }
}
