using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMasterBL.ModelsDomain
{
    public class ClientTrainingPlan
    {
        public int Id { get; set; }  // Unieke ID voor de toewijzing
        public int ClientId { get; set; }  // ID van de klant
        public int TrainingPlanId { get; set; }  // ID van het trainingsschema
        public DateTime AssignedDate { get; set; }  // Datum waarop het schema is toegewezen

        public TrainingPlan TrainingPlan { get; set; }
    }

}
