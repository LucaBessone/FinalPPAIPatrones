﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PPAI_DSI_EntregaFinalPatrones.Entidades;

namespace FinalPPAIPatrones.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231122214420_migracion2")]
    partial class migracion2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.CambioDeEstado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Llamadaid")
                        .HasColumnType("int");

                    b.Property<int?>("estadoid")
                        .HasColumnType("int");

                    b.Property<DateTime?>("fechaHoraFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaHoraInicio")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("Llamadaid");

                    b.HasIndex("estadoid");

                    b.ToTable("CambioDeEstado");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<string>("nombreCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("numeroCelular")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.Encuesta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaFinVigencia")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Encuesta");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.Estado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.Llamada", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("clienteid")
                        .HasColumnType("int");

                    b.Property<int>("descripcionOperador")
                        .HasColumnType("int");

                    b.Property<int>("detalleAccionRequerida")
                        .HasColumnType("int");

                    b.Property<int>("duracion")
                        .HasColumnType("int");

                    b.Property<int?>("encuestaEnviadaid")
                        .HasColumnType("int");

                    b.Property<int>("observacionAuditor")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.HasIndex("encuestaEnviadaid");

                    b.ToTable("Llamada");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.Pregunta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Encuestaid")
                        .HasColumnType("int");

                    b.Property<string>("pregunta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Encuestaid");

                    b.ToTable("Pregunta");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.RespuestaDeCliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Llamadaid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaEncuesta")
                        .HasColumnType("datetime2");

                    b.Property<int?>("respuestaPosibleid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Llamadaid");

                    b.HasIndex("respuestaPosibleid");

                    b.ToTable("RespuestaDeCliente");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.RespuestaPosible", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Preguntaid")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Preguntaid");

                    b.ToTable("RespuestaPosible");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.CambioDeEstado", b =>
                {
                    b.HasOne("PPAI_CU44_G1_3K6.Entidades.Llamada", null)
                        .WithMany("cambioDeEstado")
                        .HasForeignKey("Llamadaid");

                    b.HasOne("PPAI_CU44_G1_3K6.Entidades.Estado", "estado")
                        .WithMany()
                        .HasForeignKey("estadoid");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.Llamada", b =>
                {
                    b.HasOne("PPAI_CU44_G1_3K6.Entidades.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteid");

                    b.HasOne("PPAI_CU44_G1_3K6.Entidades.Encuesta", "encuestaEnviada")
                        .WithMany()
                        .HasForeignKey("encuestaEnviadaid");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.Pregunta", b =>
                {
                    b.HasOne("PPAI_CU44_G1_3K6.Entidades.Encuesta", null)
                        .WithMany("preguntas")
                        .HasForeignKey("Encuestaid");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.RespuestaDeCliente", b =>
                {
                    b.HasOne("PPAI_CU44_G1_3K6.Entidades.Llamada", null)
                        .WithMany("respuestaDeCliente")
                        .HasForeignKey("Llamadaid");

                    b.HasOne("PPAI_CU44_G1_3K6.Entidades.RespuestaPosible", "respuestaPosible")
                        .WithMany()
                        .HasForeignKey("respuestaPosibleid");
                });

            modelBuilder.Entity("PPAI_CU44_G1_3K6.Entidades.RespuestaPosible", b =>
                {
                    b.HasOne("PPAI_CU44_G1_3K6.Entidades.Pregunta", null)
                        .WithMany("respuesta")
                        .HasForeignKey("Preguntaid");
                });
#pragma warning restore 612, 618
        }
    }
}
