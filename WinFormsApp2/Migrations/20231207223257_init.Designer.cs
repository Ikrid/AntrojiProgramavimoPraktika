﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp2;

#nullable disable

namespace WinFormsApp2.Migrations
{
    [DbContext(typeof(DuomenuContext))]
    [Migration("20231207223257_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WinFormsApp2.Grupe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Grupes");
                });

            modelBuilder.Entity("WinFormsApp2.Kursas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Kursai");
                });

            modelBuilder.Entity("WinFormsApp2.Pazymys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("KursasId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KursasId");

                    b.HasIndex("UserId");

                    b.ToTable("Pazymiai");
                });

            modelBuilder.Entity("WinFormsApp2.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("GrupeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupeId");

                    b.ToTable("Naudotojai");
                });

            modelBuilder.Entity("kursasgrupe", b =>
                {
                    b.Property<int>("GrupesId")
                        .HasColumnType("int");

                    b.Property<int>("KursaiId")
                        .HasColumnType("int");

                    b.HasKey("GrupesId", "KursaiId");

                    b.HasIndex("KursaiId");

                    b.ToTable("kursasgrupe");
                });

            modelBuilder.Entity("kursasnaudotojai", b =>
                {
                    b.Property<int>("KursaiId")
                        .HasColumnType("int");

                    b.Property<int>("NaudotojaiId")
                        .HasColumnType("int");

                    b.HasKey("KursaiId", "NaudotojaiId");

                    b.HasIndex("NaudotojaiId");

                    b.ToTable("kursasnaudotojai");
                });

            modelBuilder.Entity("WinFormsApp2.Pazymys", b =>
                {
                    b.HasOne("WinFormsApp2.Kursas", "Kursas")
                        .WithMany("Pazymiai")
                        .HasForeignKey("KursasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsApp2.User", "User")
                        .WithMany("Pazymiai")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kursas");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WinFormsApp2.User", b =>
                {
                    b.HasOne("WinFormsApp2.Grupe", "Grupe")
                        .WithMany("Naudotojai")
                        .HasForeignKey("GrupeId");

                    b.Navigation("Grupe");
                });

            modelBuilder.Entity("kursasgrupe", b =>
                {
                    b.HasOne("WinFormsApp2.Grupe", null)
                        .WithMany()
                        .HasForeignKey("GrupesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsApp2.Kursas", null)
                        .WithMany()
                        .HasForeignKey("KursaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("kursasnaudotojai", b =>
                {
                    b.HasOne("WinFormsApp2.Kursas", null)
                        .WithMany()
                        .HasForeignKey("KursaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormsApp2.User", null)
                        .WithMany()
                        .HasForeignKey("NaudotojaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WinFormsApp2.Grupe", b =>
                {
                    b.Navigation("Naudotojai");
                });

            modelBuilder.Entity("WinFormsApp2.Kursas", b =>
                {
                    b.Navigation("Pazymiai");
                });

            modelBuilder.Entity("WinFormsApp2.User", b =>
                {
                    b.Navigation("Pazymiai");
                });
#pragma warning restore 612, 618
        }
    }
}
