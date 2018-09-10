﻿// <auto-generated />
using System;
using Biblioteca.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Biblioteca.Migrations
{
    [DbContext(typeof(BibliotecaContexto))]
    partial class BibliotecaContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Biblioteca.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_cliente");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nm_cliente")
                        .HasMaxLength(100);

                    b.Property<string>("Ra")
                        .IsRequired()
                        .HasColumnName("ra_cliente")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("cliente","biblioteca");
                });

            modelBuilder.Entity("Biblioteca.Models.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_emprestimo");

                    b.Property<DateTime>("DataAluguel")
                        .HasColumnName("dt_aluguel_emprestimo");

                    b.Property<DateTime>("DataEntrega")
                        .HasColumnName("dt_entrega_emprestimo");

                    b.Property<int>("IdCliente")
                        .HasColumnName("id_cliente_emprestimo");

                    b.Property<int>("IdLivro")
                        .HasColumnName("id_livro_emprestimo");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdLivro");

                    b.ToTable("emprestimo","biblioteca");
                });

            modelBuilder.Entity("Biblioteca.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id_livro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("ds_livro")
                        .HasMaxLength(500);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nm_livro")
                        .HasMaxLength(100);

                    b.Property<int>("Status")
                        .HasColumnName("st_livro")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("livro","biblioteca");
                });

            modelBuilder.Entity("Biblioteca.Models.Emprestimo", b =>
                {
                    b.HasOne("Biblioteca.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Biblioteca.Models.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("IdLivro")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}