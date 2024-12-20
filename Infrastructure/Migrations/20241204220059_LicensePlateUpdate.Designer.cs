﻿// <auto-generated />
using System;
using Infrastrucute.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CarRentalDbContext))]
    [Migration("20241204220059_LicensePlateUpdate")]
    partial class LicensePlateUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Domain.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Carro_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoriaId");

                    b.Property<string>("LicensePlate")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("Placa");

                    b.Property<string>("Manufacturer")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Fabricante");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Modelo");

                    b.Property<int>("Year")
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("int")
                        .HasColumnName("Ano");

                    b.HasKey("Id")
                        .HasName("PK__Carro__6467B009831ED7AB");

                    b.HasIndex("CategoryId");

                    b.ToTable("Carro", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoriaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nome");

                    b.HasKey("Id")
                        .HasName("PK__Categori__F353C1E5ACF1952A");

                    b.ToTable("Categoria", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Endereco");

                    b.Property<string>("Cpf")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("Telefone");

                    b.HasKey("Id")
                        .HasName("PK__Cliente__71ABD087D410F494");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FuncionarioId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("Telefone");

                    b.Property<string>("Role")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Cargo");

                    b.HasKey("Id")
                        .HasName("PK__Funciona__297ECCAAF8D468AE");

                    b.ToTable("Funcionario", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PagamentoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("Data");

                    b.Property<string>("Method")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Metodo");

                    b.Property<int>("RentalId")
                        .HasColumnType("int")
                        .HasColumnName("LocacaoId");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal?>("Value")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("Valor");

                    b.HasKey("Id")
                        .HasName("PK__Pagament__977DE7F3FD4262ED");

                    b.HasIndex("RentalId");

                    b.ToTable("Pagamento", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LocacaoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("Carro_id");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("ClienteId");

                    b.Property<DateTime>("DevolutionDate")
                        .HasColumnType("datetime")
                        .HasColumnName("DataDevolucao");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("FuncionarioId");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int")
                        .HasColumnName("ReservaId");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("TotalValue")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("ValorTotal");

                    b.Property<DateTime>("WithdrawalDate")
                        .HasColumnType("datetime")
                        .HasColumnName("DataRetirada");

                    b.HasKey("Id")
                        .HasName("PK__Locacao__31DA8772AB53BD5A");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Locacao", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReservaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("Carro_Id");

                    b.Property<int>("ClientId")
                        .HasColumnType("int")
                        .HasColumnName("ClienteId");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Data_fim");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime")
                        .HasColumnName("Data_inicio");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("PK__Reserva__C399376365B93271");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId");

                    b.ToTable("Reserva", (string)null);
                });

            modelBuilder.Entity("Core.Domain.Entities.Car", b =>
                {
                    b.HasOne("Core.Domain.Entities.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK__Carro__Categoria__4F7CD00D");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Core.Domain.Entities.Payment", b =>
                {
                    b.HasOne("Core.Domain.Entities.Rental", "Rental")
                        .WithMany("Payments")
                        .HasForeignKey("RentalId")
                        .IsRequired()
                        .HasConstraintName("FK__Pagamento__Locac__5BE2A6F2");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Core.Domain.Entities.Rental", b =>
                {
                    b.HasOne("Core.Domain.Entities.Car", "Car")
                        .WithMany("Rentals")
                        .HasForeignKey("CarId")
                        .IsRequired()
                        .HasConstraintName("FK__Locacao__Carro_i__5812160E");

                    b.HasOne("Core.Domain.Entities.Customer", "Customer")
                        .WithMany("Rentals")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK__Locacao__Cliente__571DF1D5");

                    b.HasOne("Core.Domain.Entities.Employee", "Employee")
                        .WithMany("Rentals")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK__Locacao__Funcion__59063A47");

                    b.HasOne("Core.Domain.Entities.Reservation", "Reservation")
                        .WithMany("Rentals")
                        .HasForeignKey("ReservationId")
                        .IsRequired()
                        .HasConstraintName("FK__Locacao__Reserva__5629CD9C");

                    b.Navigation("Car");

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Core.Domain.Entities.Reservation", b =>
                {
                    b.HasOne("Core.Domain.Entities.Car", "Car")
                        .WithMany("Reservations")
                        .HasForeignKey("CarId")
                        .IsRequired()
                        .HasConstraintName("FK__Reserva__Carro_i__534D60F1");

                    b.HasOne("Core.Domain.Entities.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("ClientId")
                        .IsRequired()
                        .HasConstraintName("FK__Reserva__Cliente__52593CB8");

                    b.Navigation("Car");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Core.Domain.Entities.Car", b =>
                {
                    b.Navigation("Rentals");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Core.Domain.Entities.Category", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Core.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Rentals");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Core.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("Core.Domain.Entities.Rental", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Core.Domain.Entities.Reservation", b =>
                {
                    b.Navigation("Rentals");
                });
#pragma warning restore 612, 618
        }
    }
}
