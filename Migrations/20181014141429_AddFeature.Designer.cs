﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using angular_dotnet.Persistence;

namespace angulardotnet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181014141429_AddFeature")]
    partial class AddFeature
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("angular_dotnet.Models.Feature", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("id");

                    b.ToTable("features");
                });

            modelBuilder.Entity("angular_dotnet.Models.Make", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("id");

                    b.ToTable("makes");
                });

            modelBuilder.Entity("angular_dotnet.Models.Model", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("makeid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("id");

                    b.HasIndex("makeid");

                    b.ToTable("models");
                });

            modelBuilder.Entity("angular_dotnet.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("angular_dotnet.Models.Model", b =>
                {
                    b.HasOne("angular_dotnet.Models.Make", "make")
                        .WithMany("models")
                        .HasForeignKey("makeid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
