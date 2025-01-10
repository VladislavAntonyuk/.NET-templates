﻿// <auto-generated />
using System;
using App1.Modules.Module2s.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App1.Modules.Module2s.Infrastructure.Database.Migrations
{
    [DbContext(typeof(Module2sDbContext))]
    partial class Module2sDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("App1.Module2s")
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("App1.Common.Infrastructure.Inbox.InboxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Error")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OccurredOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ProcessedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("InboxMessages", "App1.Module2s");
                });

            modelBuilder.Entity("App1.Common.Infrastructure.Outbox.OutboxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Error")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OccurredOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ProcessedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OutboxMessages", "App1.Module2s");
                });

            modelBuilder.Entity("App1.Modules.Module2s.Domain.Module2s.Module2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Module2S", "App1.Module2s");
                });
#pragma warning restore 612, 618
        }
    }
}
