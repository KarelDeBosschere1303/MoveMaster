using MoveMasterBL.Interfaces;
using MoveMasterBL.ModelsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveMasterBL.Managers
{
    public class TrainingPlanManager
    {
        private readonly ITrainingPlanRepo _trainingPlanRepo;

        public TrainingPlanManager(ITrainingPlanRepo trainingPlanRepo)
        {
            _trainingPlanRepo = trainingPlanRepo;
        }

        public void CreateTrainingPlan(TrainingPlan plan)
        {
            // Eventuele validatie van het schema
            if (string.IsNullOrWhiteSpace(plan.Name) || plan.Exercises == null || !plan.Exercises.Any())
            {
                throw new ArgumentException("Training plan must have a name and at least one exercise.");
            }

            _trainingPlanRepo.Create(plan);
        }

        public TrainingPlan GetTrainingPlanById(int id) => _trainingPlanRepo.GetById(id);

        public List<TrainingPlan> GetTrainingPlansByTrainer(int trainerId) => _trainingPlanRepo.GetByTrainerId(trainerId);
    }
}
