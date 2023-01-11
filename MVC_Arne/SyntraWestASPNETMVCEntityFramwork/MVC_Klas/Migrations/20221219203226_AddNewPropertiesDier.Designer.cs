﻿// <auto-generated />
using MVC_Klas.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCKlas.Migrations
{
    [DbContext(typeof(KlasContext))]
    [Migration("20221219203226_AddNewPropertiesDier")]
    partial class AddNewPropertiesDier
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_Klas.Models.Dier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AantalPoten")
                        .HasColumnType("int");

                    b.Property<string>("Benaming")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FamilieID")
                        .HasColumnType("int");

                    b.Property<string>("Geslacht")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GeslachtNaam");

                    b.Property<bool>("Gevaarlijk")
                        .HasColumnType("bit")
                        .HasColumnName("GevaarlijkNaam");

                    b.Property<string>("Kleur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("FamilieID");

                    b.ToTable("DierenLijst");
                });

            modelBuilder.Entity("MVC_Klas.Models.Familie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("FamilieScore")
                        .HasColumnType("int");

                    b.Property<string>("Klasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Orde")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("MVC_Klas.Models.Dier", b =>
                {
                    b.HasOne("MVC_Klas.Models.Familie", "Familie")
                        .WithMany()
                        .HasForeignKey("FamilieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Familie");
                });
#pragma warning restore 612, 618
        }
    }
}