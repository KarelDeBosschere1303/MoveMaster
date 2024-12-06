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
    public class TrainingPlanRepo : ITrainingPlanRepo
    {
        private readonly MoveMasterContext _context;

        public TrainingPlanRepo(MoveMasterContext context)
        {
            _context = context;
        }

        public void Create(TrainingPlan plan)
        {
            _context.TrainingPlans.Add(plan);
            _context.SaveChanges();
        }

        public TrainingPlan GetById(int id)
        {
            return _context.TrainingPlans
                .Include(tp => tp.Exercises)
                .FirstOrDefault(tp => tp.Id == id);
        }

        public List<TrainingPlan> GetByTrainerId(int trainerId)
        {
            return _context.TrainingPlans
                .Where(tp => tp.TrainerId == trainerId)
                .ToList();
        }
    }
}
