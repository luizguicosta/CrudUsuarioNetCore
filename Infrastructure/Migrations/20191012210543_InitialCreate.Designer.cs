﻿// <auto-generated />
using System;
using Infrastructure.Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20191012210543_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Funcionalidade", b =>
                {
                    b.Property<int>("IdFuncionalidade")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro");

                    b.Property<int?>("IdPerfil");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("IdFuncionalidade");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Funcionalidade");
                });

            modelBuilder.Entity("Domain.Entities.Perfil", b =>
                {
                    b.Property<int>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("NomePerfil")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("IdPerfil");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro");

                    b.Property<int>("IdPerfil");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdPerfil");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Funcionalidade", b =>
                {
                    b.HasOne("Domain.Entities.Perfil", "Perfil")
                        .WithMany("Funcionalidades")
                        .HasForeignKey("IdPerfil");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.HasOne("Domain.Entities.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("IdPerfil")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
