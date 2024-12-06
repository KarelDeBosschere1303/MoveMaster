using MoveMasterBL.Interfaces;
using MoveMasterBL.ModelsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMasterBL.Managers
{
    public class ClientTrainingPlanManager
    {
        private readonly IClientTrainingPlanRepo _clientTrainingPlanRepo;

        public ClientTrainingPlanManager(IClientTrainingPlanRepo clientTrainingPlanRepo)
        {
            _clientTrainingPlanRepo = clientTrainingPlanRepo;
        }

        public void AssignPlanToClient(int clientId, int trainingPlanId)
        {
            // Eventuele validatie kan hier worden toegevoegd
            _clientTrainingPlanRepo.AssignToClient(clientId, trainingPlanId);
        }

        public List<TrainingPlan> GetTrainingPlansForClient(int clientId) => _clientTrainingPlanRepo.GetPlansForClient(clientId);
    }
}
