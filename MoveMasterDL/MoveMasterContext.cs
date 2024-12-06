using MoveMasterBL.ModelsDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MoveMasterDL
{
    public class MoveMasterContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        public DbSet<ClientTrainingPlan> ClientTrainingPlans { get; set; }

        public MoveMasterContext(DbContextOptions<MoveMasterContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuratie van relaties
            modelBuilder.Entity<ClientTrainingPlan>()
                .HasOne(ctp => ctp.TrainingPlan)  // Relatie met TrainingPlan
                .WithMany()  // Eén TrainingPlan kan meerdere ClientTrainingPlans hebben
                .HasForeignKey(ctp => ctp.TrainingPlanId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ClientTrainingPlan>()
                .HasOne<User>()  // Relatie met User (Client)
                .WithMany()
                .HasForeignKey(ctp => ctp.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
