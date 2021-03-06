﻿// <auto-generated />
using System;
using Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dal.Migrations
{
    [DbContext(typeof(CoreHrContext))]
    [Migration("20180827143809_SalaryDetailsChange")]
    partial class SalaryDetailsChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview1-35029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Types.Competency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Competency");
                });

            modelBuilder.Entity("Types.Dependant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmergencyPhoneNumber");

                    b.Property<int>("EmployeeId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Relation");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Dependant");
                });

            modelBuilder.Entity("Types.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("EmploymentDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Types.EmployeeCompetencies", b =>
                {
                    b.Property<int>("EmployeeId");

                    b.Property<int>("CompetencyId");

                    b.HasKey("EmployeeId", "CompetencyId");

                    b.HasIndex("CompetencyId");

                    b.ToTable("EmployeeCompetencies");
                });

            modelBuilder.Entity("Types.EmployeeSalaryDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AnnualVariableSalary");

                    b.Property<decimal>("BaseSalary");

                    b.Property<int>("EmployeeId");

                    b.Property<int>("PaymentFrequency");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("SalaryDetails");
                });

            modelBuilder.Entity("Types.Dependant", b =>
                {
                    b.HasOne("Types.Employee")
                        .WithMany("Dependants")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Types.EmployeeCompetencies", b =>
                {
                    b.HasOne("Types.Competency", "Competency")
                        .WithMany("EmployeeCompetencies")
                        .HasForeignKey("CompetencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Types.Employee", "Employee")
                        .WithMany("EmployeeCompetencies")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Types.EmployeeSalaryDetails", b =>
                {
                    b.HasOne("Types.Employee", "Employee")
                        .WithOne("SalaryDetails")
                        .HasForeignKey("Types.EmployeeSalaryDetails", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
