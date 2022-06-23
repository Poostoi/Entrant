﻿// <auto-generated />
using System;
using Enrollee.Ef.Migrator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Enrollee.Ef.Migrator.Migrations
{
    [DbContext(typeof(MigratorDbContext))]
    partial class MigratorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Enrollee.Domain.Models.AboutOfEntrant.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CharacterEducation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PlaceIdEducation")
                        .HasColumnType("integer");

                    b.Property<string>("TypeEducationalInstitution")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Educations", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.AboutOfEntrant.Entrant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("EducationId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EntrantAddressId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MaritalStatusId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PassportDataId")
                        .HasColumnType("uuid");

                    b.Property<int>("PlaceIdBirth")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("VacancyId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EducationId")
                        .IsUnique();

                    b.HasIndex("EntrantAddressId")
                        .IsUnique();

                    b.HasIndex("MaritalStatusId")
                        .IsUnique();

                    b.HasIndex("PassportDataId")
                        .IsUnique();

                    b.HasIndex("VacancyId");

                    b.ToTable("Entrants", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.AboutOfEntrant.MaritalStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("BrotherSister")
                        .HasColumnType("integer");

                    b.Property<int?>("Children")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Family")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("MaritalStatus", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.AboutOfEntrant.Nationality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NameNationality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Nationalities", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.AboutOfEntrant.PassportData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("ItIsGiven")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("NationalityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Patronomic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Series")
                        .HasColumnType("integer");

                    b.Property<int>("Sex")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("NationalityId");

                    b.ToTable("PassportData", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Countries", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Destrict", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("RegionId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Districts", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.EntrantAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("Floor")
                        .HasColumnType("integer");

                    b.Property<int?>("HomeTelethone")
                        .HasColumnType("integer");

                    b.Property<bool>("IsApartament")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsHostel")
                        .HasColumnType("boolean");

                    b.Property<int?>("NumberApartament")
                        .HasColumnType("integer");

                    b.Property<int>("NumberHome")
                        .HasColumnType("integer");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CountryId")
                        .IsUnique();

                    b.ToTable("EntrantAddress", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Place", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DestrictId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DestrictId");

                    b.ToTable("Places", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CountryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.User.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Accounts", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.User.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Vacancy.Faculty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ExternalId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Faculties", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Vacancy.Language", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Languages", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Vacancy.Speciality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("FacultyId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Specialties", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Vacancy.Vacancy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ExternalId")
                        .HasColumnType("integer");

                    b.Property<int>("Forma")
                        .HasColumnType("integer");

                    b.Property<Guid?>("LanguageId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("SpecialityId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("VacancyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Vacancies", (string)null);
                });

            modelBuilder.Entity("Enrollee.Domain.Models.AboutOfEntrant.Entrant", b =>
                {
                    b.HasOne("Enrollee.Domain.Models.AboutOfEntrant.Education", "Education")
                        .WithOne("Entrant")
                        .HasForeignKey("Enrollee.Domain.Models.AboutOfEntrant.Entrant", "EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Enrollee.Domain.Models.EntrantAddress", "EntrantAddress")
                        .WithOne("Entrant")
                        .HasForeignKey("Enrollee.Domain.Models.AboutOfEntrant.Entrant", "EntrantAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Enrollee.Domain.Models.AboutOfEntrant.MaritalStatus", "MaritalStatus")
                        .WithOne("Entrant")
                        .HasForeignKey("Enrollee.Domain.Models.AboutOfEntrant.Entrant", "MaritalStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Enrollee.Domain.Models.AboutOfEntrant.PassportData", "PassportData")
                        .WithOne("Entrant")
                        .HasForeignKey("Enrollee.Domain.Models.AboutOfEntrant.Entrant", "PassportDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Enrollee.Domain.Models.Vacancy.Vacancy", "Vacancy")
                        .WithMany("Entrants")
                        .HasForeignKey("VacancyId");

                    b.Navigation("Education");

                    b.Navigation("EntrantAddress");

                    b.Navigation("MaritalStatus");

                    b.Navigation("PassportData");

                    b.Navigation("Vacancy");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.AboutOfEntrant.PassportData", b =>
                {
                    b.HasOne("Enrollee.Domain.Models.AboutOfEntrant.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nationality");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Destrict", b =>
                {
                    b.HasOne("Enrollee.Domain.Models.Region", "Region")
                        .WithMany("Destricts")
                        .HasForeignKey("RegionId");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.EntrantAddress", b =>
                {
                    b.HasOne("Enrollee.Domain.Models.Country", "Country")
                        .WithOne("EntrantAddress")
                        .HasForeignKey("Enrollee.Domain.Models.EntrantAddress", "CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Place", b =>
                {
                    b.HasOne("Enrollee.Domain.Models.Destrict", "Destrict")
                        .WithMany("Places")
                        .HasForeignKey("DestrictId");

                    b.Navigation("Destrict");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Region", b =>
                {
                    b.HasOne("Enrollee.Domain.Models.Country", "Country")
                        .WithMany("Regions")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.User.Role", b =>
                {
                    b.HasOne("Enrollee.Domain.Models.User.Account", null)
                        .WithMany("Roles")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Vacancy.Speciality", b =>
                {
                    b.HasOne("Enrollee.Domain.Models.Vacancy.Faculty", "Faculty")
                        .WithMany("Specialities")
                        .HasForeignKey("FacultyId");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Vacancy.Vacancy", b =>
                {
                    b.HasOne("Enrollee.Domain.Models.Vacancy.Language", "Language")
                        .WithMany("Vacancies")
                        .HasForeignKey("LanguageId");

                    b.HasOne("Enrollee.Domain.Models.Vacancy.Speciality", "Speciality")
                        .WithMany("Vacancies")
                        .HasForeignKey("SpecialityId");

                    b.Navigation("Language");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.AboutOfEntrant.Education", b =>
                {
                    b.Navigation("Entrant")
                        .IsRequired();
                });

            modelBuilder.Entity("Enrollee.Domain.Models.AboutOfEntrant.MaritalStatus", b =>
                {
                    b.Navigation("Entrant")
                        .IsRequired();
                });

            modelBuilder.Entity("Enrollee.Domain.Models.AboutOfEntrant.PassportData", b =>
                {
                    b.Navigation("Entrant")
                        .IsRequired();
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Country", b =>
                {
                    b.Navigation("EntrantAddress")
                        .IsRequired();

                    b.Navigation("Regions");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Destrict", b =>
                {
                    b.Navigation("Places");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.EntrantAddress", b =>
                {
                    b.Navigation("Entrant")
                        .IsRequired();
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Region", b =>
                {
                    b.Navigation("Destricts");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.User.Account", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Vacancy.Faculty", b =>
                {
                    b.Navigation("Specialities");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Vacancy.Language", b =>
                {
                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Vacancy.Speciality", b =>
                {
                    b.Navigation("Vacancies");
                });

            modelBuilder.Entity("Enrollee.Domain.Models.Vacancy.Vacancy", b =>
                {
                    b.Navigation("Entrants");
                });
#pragma warning restore 612, 618
        }
    }
}