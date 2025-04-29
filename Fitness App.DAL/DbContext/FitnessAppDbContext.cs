using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Fitness_App.DAL.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Fitness_App.BL.Models;

namespace Fitness_App.DAL.DbContext
{
    public class FitnessAppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public FitnessAppDbContext(DbContextOptions<FitnessAppDbContext> opton) : base(opton)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Date>();
            #region comment
            //#region ProgressLog
            ////ProgressLog
            //modelBuilder.Entity<ProgressLog>(entity =>
            //{

            //    entity.HasKey(pl => pl.ProgressLogId);


            //    entity.HasOne(pl => pl.Client)
            //      .WithMany(c => c.ProgressLogs)
            //      .HasForeignKey(pl => pl.ClientId)
            //      .OnDelete(DeleteBehavior.Cascade);
            //});
            //#endregion
            //#region Client


            //modelBuilder.Entity<Client>(entity =>
            //{

            //    //entity.HasKey(c => c.ClientId);


            //    entity.Property(c => c.HealthConditions)
            //          .HasMaxLength(500);

            //    entity.Property(c => c.FitnessGoals)
            //          .HasMaxLength(500);

            //    entity.Property(c => c.ActivityLevel)
            //          .HasMaxLength(100);

            //    // Relationships

            //    // Client -> ProgressLogs (1 to many)
            //    entity.HasMany(c => c.ProgressLogs)
            //          .WithOne(pl => pl.Client)
            //          .HasForeignKey(pl => pl.ClientId)
            //          .OnDelete(DeleteBehavior.NoAction);

            //    // Client -> Messages (assuming Message has a ClientId FK)
            //    entity.HasMany(c => c.messages)
            //          .WithOne()
            //          .HasForeignKey(c => c.ClientId)
            //          .OnDelete(DeleteBehavior.NoAction);

            //    // Client -> Subscriptions (assuming Subscription has a ClientId FK)
            //    entity.HasMany(c => c.subscriptions)
            //          .WithOne()
            //          .HasForeignKey(c => c.ClientId)
            //          .OnDelete(DeleteBehavior.Restrict); //here i prevented deleting subscription
            //});

            //#endregion
            //#region Message
            ////message
            //modelBuilder.Entity<Message>(entity =>
            //{
            //    entity.HasKey(k => k.MessageId);
            //    entity.HasOne(e => e.client)
            //    .WithMany(c => c.messages)
            //    .HasForeignKey(fk => fk.ClientId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //    entity.HasOne(m => m.coach)
            //     .WithMany(e => e.messages)
            //    .HasForeignKey(m => m.CoachID)
            //    .OnDelete(DeleteBehavior.Restrict);
            //});
            //#endregion
            //#region Coach

            //modelBuilder.Entity<Coach>(entity =>
            //{
            //    //entity.HasKey(e => e.CoachID);
            //    entity.HasMany(e => e.messages)
            //    .WithOne(e => e.coach);
            //    entity.HasMany(e => e.subscriptions)
            //    .WithOne(e => e.coach)
            //    .OnDelete(DeleteBehavior.Restrict);
            //});
            //#endregion
            //#region Subscription
            //modelBuilder.Entity<Subscription>(entity =>
            //{
            //    entity.HasKey(e => e.subscriptionID);
            //    entity.HasOne(e => e.client)
            //          .WithMany(e => e.subscriptions)
            //          .HasForeignKey(e => e.ClientId)
            //          .OnDelete(DeleteBehavior.Restrict);
            //    entity.HasOne(e => e.coach)
            //          .WithMany(e => e.subscriptions)
            //          .HasForeignKey(e => e.CoachID)
            //          .OnDelete(DeleteBehavior.Restrict);
            //});
            //#endregion

            #endregion
            //User is handeled by identity package

            modelBuilder.Entity<ApplicationUser>().ToTable("Users");
            modelBuilder.Entity<Admin>().ToTable("Admins");
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Coach>().ToTable("Coaches");


        
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<DietPlans> DietPlans { get; set; }
        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ProgressLog> ProgressLog { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}
