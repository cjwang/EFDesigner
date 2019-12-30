//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sandbox
{
   /// <inheritdoc/>
   public partial class EFModel : Microsoft.EntityFrameworkCore.DbContext
   {
      #region DbSets
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Sandbox.BaseClass> BaseClasses { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Sandbox.Detail> Details { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<global::Sandbox.Master> Masters { get; set; }
      #endregion DbSets

      /// <summary>
      /// Default connection string
      /// </summary>
      public static string ConnectionString { get; set; } = @"Data Source=.;Initial Catalog=Sandbox;Integrated Security=True";

      /// <inheritdoc />
      public EFModel(DbContextOptions<EFModel> options) : base(options)
      {
      }

      partial void CustomInit(DbContextOptionsBuilder optionsBuilder);

      /// <inheritdoc />
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         CustomInit(optionsBuilder);
      }

      partial void OnModelCreatingImpl(ModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(ModelBuilder modelBuilder);

      /// <inheritdoc />
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");

         modelBuilder.Entity<global::Sandbox.BaseClass>()
                     .ToTable("BaseClasses")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::Sandbox.BaseClass>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .ValueGeneratedNever();

         modelBuilder.Entity<global::Sandbox.Detail>()
                     .HasOne(x => x.Master)
                     .WithMany(x => x.Details)
                     .HasForeignKey("Bob");

         modelBuilder.Entity<global::Sandbox.Master>()
                     .Property(t => t.StringMax)
                     .HasField("_StringMax")
                     .UsePropertyAccessMode(PropertyAccessMode.Property);
         modelBuilder.Entity<global::Sandbox.Master>().HasIndex(t => t.StringMax);

         OnModelCreatedImpl(modelBuilder);
      }
   }
}