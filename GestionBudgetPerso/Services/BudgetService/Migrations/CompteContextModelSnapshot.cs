﻿// <auto-generated />
using System;
using BudgetService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BudgetService.Migrations
{
    [DbContext(typeof(CompteContext))]
    partial class CompteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("BudgetService.Models.Compte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SoldeInitial")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Comptes");
                });
#pragma warning restore 612, 618
        }
    }
}
