using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectAlphaWebAPI.Models;

namespace ProjectAlphaWebAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20161205160103_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectAlphaWebAPI.Models.Weather", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<DateTimeOffset>("DateTime");

                    b.Property<string>("Park")
                        .HasMaxLength(50);

                    b.Property<string>("Postal")
                        .HasMaxLength(6);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Street")
                        .HasMaxLength(50);

                    b.Property<double>("Temperature");

                    b.HasKey("Id");

                    b.ToTable("Weathers");
                });
        }
    }
}
