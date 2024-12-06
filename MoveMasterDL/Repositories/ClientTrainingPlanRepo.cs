using MoveMasterBL.Interfaces;
using MoveMasterBL.ModelsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoveMasterDL;

namespace MoveMasterDL.Repositories
{
    public class ClientTrainingPlanRepo : IClientTrainingPlanRepo
    {
        private readonly MoveMasterContext _context;

        public ClientTrainingPlanRepo(MoveMasterContext context)
        {
            _context = context;
        }

        public void AssignToClient(int clientId, int trainingPlanId)
        {
            var assignment = new ClientTrainingPlan
            {
                ClientId = clientId,
                TrainingPlanId = trainingPlanId,
                AssignedDate = DateTime.Now
            };

            _context.ClientTrainingPlans.Add(assignment);
            _context.SaveChanges();
        }

        public List<TrainingPlan> GetPlansForClient(int clientId)
        {
            return _context.ClientTrainingPlans
                .Where(ctp => ctp.ClientId == clientId)
                .Include(ctp => ctp.TrainingPlan)  // Laad het gekoppelde TrainingPlan
                .Select(ctp => ctp.TrainingPlan)  // Selecteer het TrainingPlan
                .ToList();
        }
    }
}
