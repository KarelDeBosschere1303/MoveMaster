using MoveMasterBL.ModelsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMasterBL.Interfaces
{
    public interface ITrainingPlanRepo
    {
        void Create(TrainingPlan plan);
        TrainingPlan GetById(int id);
        List<TrainingPlan> GetByTrainerId(int trainerId);
    }
}
