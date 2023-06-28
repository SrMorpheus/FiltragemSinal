﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteLTrace.Models.Comtext;

#nullable disable

namespace TesteLTrace.Migrations
{
    [DbContext(typeof(TesteLTraceContext))]
    [Migration("20230626170520_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TesteLTrace.Models.ModelFiltro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("HighPass")
                        .HasColumnType("double");

                    b.Property<double>("LowPass")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("ModelFiltros");
                });

            modelBuilder.Entity("TesteLTrace.Models.ModelGrafico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("DadosSismico")
                        .HasColumnType("double");

                    b.Property<int>("ModelFiltroId")
                        .HasColumnType("int");

                    b.Property<double>("Tempo")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ModelFiltroId");

                    b.ToTable("ModelGraficos");
                });

            modelBuilder.Entity("TesteLTrace.Models.ModelGrafico", b =>
                {
                    b.HasOne("TesteLTrace.Models.ModelFiltro", null)
                        .WithMany("Resultados")
                        .HasForeignKey("ModelFiltroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TesteLTrace.Models.ModelFiltro", b =>
                {
                    b.Navigation("Resultados");
                });
#pragma warning restore 612, 618
        }
    }
}
