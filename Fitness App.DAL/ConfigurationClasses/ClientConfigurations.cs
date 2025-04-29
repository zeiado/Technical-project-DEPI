using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_App.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness_App.DAL.ConfigurationClasses
{
    public class ClientConfigurations : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> entity)
        {


            entity.Property(c => c.HealthConditions)
                  .HasMaxLength(500);

            entity.Property(c => c.FitnessGoals)
                  .HasMaxLength(500);

            entity.Property(c => c.ActivityLevel)
                  .HasMaxLength(100);

            // Relationships

            // Client -> ProgressLogs (1 to many)
            entity.HasMany(c => c.ProgressLogs)
                  .WithOne(pl => pl.Client)
                  .HasForeignKey(pl => pl.ClientId)
                  .OnDelete(DeleteBehavior.NoAction);

            // Client -> Messages (assuming Message has a ClientId FK)
            entity.HasMany(c => c.messages)
                  .WithOne()
                  .HasForeignKey(c => c.ClientId)
                  .OnDelete(DeleteBehavior.NoAction);

            // Client -> Subscriptions (assuming Subscription has a ClientId FK)
            entity.HasMany(c => c.subscriptions)
                  .WithOne()
                  .HasForeignKey(c => c.ClientId)
                  .OnDelete(DeleteBehavior.Restrict); //here i prevented deleting subscription

        }
    }
}
