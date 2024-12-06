using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMasterBL.ModelsDomain
{
    public class User
    {
        public int Id { get; set; }  // Unieke ID voor de gebruiker
        public string Name { get; set; }  // Naam van de gebruiker
        public string Email { get; set; }  // E-mailadres voor authenticatie
        public string PasswordHash { get; set; }  // Gehashte wachtwoord
        public Role Role { get; set; }  // Rol (Trainer of Klant)
    }
}
