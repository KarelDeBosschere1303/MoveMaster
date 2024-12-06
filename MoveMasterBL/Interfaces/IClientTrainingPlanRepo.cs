using MoveMasterBL.ModelsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMasterBL.Interfaces
{
    public interface IClientTrainingPlanRepo
    {
        void AssignToClient(int clientId, int trainingPlanId);
        List<TrainingPlan> GetPlansForClient(int clientId);
    }
}
