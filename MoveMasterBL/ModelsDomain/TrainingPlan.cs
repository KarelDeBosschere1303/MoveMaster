using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMasterBL.ModelsDomain
{
    public class TrainingPlan
    {
        public int Id { get; set; }  // Unieke ID voor het schema
        public string Name { get; set; }  // Naam van het schema
        public int TrainerId { get; set; }  // ID van de trainer die het schema heeft gemaakt
        public List<Exercise> Exercises { get; set; }  // Lijst van oefeningen in het schema
    }

}
