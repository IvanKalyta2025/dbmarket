using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dbmarket.Controllers;
using dbmarket.Models;

namespace dbmarket.Entities
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}