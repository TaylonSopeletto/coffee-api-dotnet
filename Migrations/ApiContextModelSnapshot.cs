﻿// <auto-generated />
using CoffeeApiV2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeApiV2.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CategoryCoffee", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("integer");

                    b.Property<int>("CoffeesId")
                        .HasColumnType("integer");

                    b.HasKey("CategoriesId", "CoffeesId");

                    b.HasIndex("CoffeesId");

                    b.ToTable("CategoryCoffee");
                });

            modelBuilder.Entity("CoffeeApiV2.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CoffeeApiV2.Models.Coffee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Coffees");
                });

            modelBuilder.Entity("CategoryCoffee", b =>
                {
                    b.HasOne("CoffeeApiV2.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoffeeApiV2.Models.Coffee", null)
                        .WithMany()
                        .HasForeignKey("CoffeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}