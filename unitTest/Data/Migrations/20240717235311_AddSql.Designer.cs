﻿// <auto-generated />
using System;
using AgendarConsultas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgendarConsultas.Data.Migrations
{
    [DbContext(typeof(ScheduleContext))]
    [Migration("20240717235311_AddSql")]
    partial class AddSql
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("AgendarConsultas.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Cell")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell");

                    b.Property<int>("ClinicId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("TEXT")
                        .HasColumnName("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.ToTable("client");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Clinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Cell")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("Schedule")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("schedule");

                    b.Property<int>("SecretaryId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("TEXT")
                        .HasColumnName("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SecretaryId");

                    b.ToTable("clinic");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Consultation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("ClinicId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PetId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Schedule")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("schedule");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("TEXT")
                        .HasColumnName("uuid");

                    b.Property<int>("VeterinaryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.HasIndex("PetId");

                    b.HasIndex("VeterinaryId")
                        .IsUnique();

                    b.ToTable("consultation");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConsultationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("Race")
                        .HasColumnType("TEXT")
                        .HasColumnName("race");

                    b.Property<string>("Schedule")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("schedule");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("TEXT")
                        .HasColumnName("uuid");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("pet");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Secretary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Cell")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("cell");

                    b.Property<int>("ClinicId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.ToTable("secretary");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Veterinary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Cell")
                        .HasColumnType("TEXT")
                        .HasColumnName("cell");

                    b.Property<int>("ClinicId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConsultarionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("Schedule")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("schedule");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("TEXT")
                        .HasColumnName("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.ToTable("veterinary");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Client", b =>
                {
                    b.HasOne("AgendarConsultas.Model.Clinic", "Clinic")
                        .WithMany("Clients")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Clinic", b =>
                {
                    b.HasOne("AgendarConsultas.Model.Secretary", "Secretary")
                        .WithMany()
                        .HasForeignKey("SecretaryId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Secretary");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Consultation", b =>
                {
                    b.HasOne("AgendarConsultas.Model.Clinic", "Clinic")
                        .WithMany("Consultations")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgendarConsultas.Model.Pet", "Pet")
                        .WithMany("Consultations")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgendarConsultas.Model.Veterinary", "Veterinary")
                        .WithOne("Consultation")
                        .HasForeignKey("AgendarConsultas.Model.Consultation", "VeterinaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Pet");

                    b.Navigation("Veterinary");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Pet", b =>
                {
                    b.HasOne("AgendarConsultas.Model.Client", "Client")
                        .WithMany("Pets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Secretary", b =>
                {
                    b.HasOne("AgendarConsultas.Model.Clinic", "Clinic")
                        .WithMany()
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Veterinary", b =>
                {
                    b.HasOne("AgendarConsultas.Model.Clinic", "Clinic")
                        .WithMany()
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Client", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Clinic", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Consultations");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Pet", b =>
                {
                    b.Navigation("Consultations");
                });

            modelBuilder.Entity("AgendarConsultas.Model.Veterinary", b =>
                {
                    b.Navigation("Consultation")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
