using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMasterBL.ModelsDomain
{
    public class Exercise
    {
        public int Id { get; set; }  // Unieke ID voor de oefening
        public string Name { get; set; }  // Naam van de oefening (bijv. Push-ups)
        public int Sets { get; set; }  // Aantal sets
        public int Repetitions { get; set; }  // Aantal herhalingen per set
    }
}
