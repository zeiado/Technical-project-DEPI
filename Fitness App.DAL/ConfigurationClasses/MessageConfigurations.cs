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
    public class MessageConfigurations : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> entity)
        {


            entity.HasKey(k => k.MessageId);
            entity.HasOne(e => e.client)
            .WithMany(c => c.messages)
            .HasForeignKey(fk => fk.ClientId)
            .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(m => m.coach)
             .WithMany(e => e.messages)
            .HasForeignKey(m => m.CoachID)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
