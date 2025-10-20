using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing.Matching;

namespace dbmarket.Models
{
    public class Applicants
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int CardNumber { get; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Adresse { get; set; }
        public string? Description { get; set; }

        public Applicants(int cardnumber, string? name, string? lastname, int age, string? adresse, string? description)
        {
            Id = Guid.NewGuid();
            CardNumber = cardnumber;
            Name = name;
            LastName = lastname;
            Age = age;
            Adresse = adresse;
            Description = description;
        }
    }
}
