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
    public class CoachConfigurations: IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> entity)
        {

            entity.HasMany(e => e.messages)
                            .WithOne(e => e.coach);
            entity.HasMany(e => e.subscriptions)
            .WithOne(e => e.coach)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
