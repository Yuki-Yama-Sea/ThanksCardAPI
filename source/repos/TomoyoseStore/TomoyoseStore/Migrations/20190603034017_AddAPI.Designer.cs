﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TomoyoseStore.Models;

namespace TomoyoseStore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190603034017_AddAPI")]
    partial class AddAPI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TomoyoseStore.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CD");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Favorite");

                    b.Property<int?>("FromId");

                    b.Property<int>("PickUp");

                    b.Property<int>("Reply");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.Property<int?>("ToId");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("TomoyoseStore.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CD");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TomoyoseStore.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CD");

                    b.Property<string>("Mailaddress");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int?>("SectionId");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TomoyoseStore.Models.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CardId");

                    b.Property<int?>("EmployeeId");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("TomoyoseStore.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CD");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("TomoyoseStore.Models.Card", b =>
                {
                    b.HasOne("TomoyoseStore.Models.Employee", "From")
                        .WithMany()
                        .HasForeignKey("FromId");

                    b.HasOne("TomoyoseStore.Models.Employee", "To")
                        .WithMany()
                        .HasForeignKey("ToId");
                });

            modelBuilder.Entity("TomoyoseStore.Models.Employee", b =>
                {
                    b.HasOne("TomoyoseStore.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("TomoyoseStore.Models.Favorite", b =>
                {
                    b.HasOne("TomoyoseStore.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId");

                    b.HasOne("TomoyoseStore.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("TomoyoseStore.Models.Section", b =>
                {
                    b.HasOne("TomoyoseStore.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
