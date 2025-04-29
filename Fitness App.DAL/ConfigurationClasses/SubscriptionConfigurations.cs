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
    internal class SubscriptionConfigurations: IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> entity)
        {


            entity.HasKey(e => e.subscriptionID);
            entity.HasOne(e => e.client)
                  .WithMany(e => e.subscriptions)
                  .HasForeignKey(e => e.ClientId)
                  .OnDelete(DeleteBehavior.Restrict);
            entity.HasOne(e => e.coach)
                  .WithMany(e => e.subscriptions)
                  .HasForeignKey(e => e.CoachID)
                  .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
