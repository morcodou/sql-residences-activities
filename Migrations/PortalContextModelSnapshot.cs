﻿// <auto-generated />
using System;
using FabrikamResidences_Activities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FabrikamResidencesActivities.Migrations
{
    [DbContext(typeof(PortalContext))]
    partial class PortalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FabrikamResidences_Activities.Models.Attendee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("PortalActivityId");

                    b.HasKey("Id");

                    b.HasIndex("PortalActivityId");

                    b.ToTable("Attendee");

                    b.HasData(
                        new { Id = 1, Email = "Joe@Addict.com", FirstName = "Joe", LastName = "Bingo", PortalActivityId = 1 },
                        new { Id = 2, Email = "jdoe@anonymous.com", FirstName = "john", LastName = "doe", PortalActivityId = 1 },
                        new { Id = 3, Email = "champ@shuffleboard.com", FirstName = "Jill", LastName = "Hill", PortalActivityId = 2 },
                        new { Id = 4, Email = "jdoe@anonymous.com", FirstName = "John", LastName = "Doe", PortalActivityId = 2 }
                    );
                });

            modelBuilder.Entity("FabrikamResidences_Activities.Models.PortalActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PortalActivity");

                    b.HasData(
                        new { Id = 1, Date = new DateTime(2020, 9, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), Description = "Come join us for an exciting game of Bingo with great prizes.", Name = "Bingo" },
                        new { Id = 2, Date = new DateTime(2020, 9, 14, 18, 0, 0, 0, DateTimeKind.Unspecified), Description = "Meet us at the Shuffleboard court!", Name = "Shuffleboard Competition" }
                    );
                });

            modelBuilder.Entity("FabrikamResidences_Activities.Models.Attendee", b =>
                {
                    b.HasOne("FabrikamResidences_Activities.Models.PortalActivity")
                        .WithMany("Attendees")
                        .HasForeignKey("PortalActivityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
