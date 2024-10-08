﻿// <auto-generated />
using System;
using Desafio3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Desafio3_DM201736_DV201086_PC191777.Migrations
{
    [DbContext(typeof(RecetaDBContext))]
    [Migration("20241008204555_inicio45")]
    partial class inicio45
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Desafio3_DM201736_DV201086_PC191777.Models.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Cantidad")
                        .HasColumnType("float");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RecetaId")
                        .HasColumnType("int");

                    b.Property<string>("Unidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecetaId");

                    b.ToTable("Ingredientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cantidad = 1.0,
                            Nombre = "Lechuga Romana",
                            RecetaId = 1,
                            Unidad = "Unidad"
                        },
                        new
                        {
                            Id = 2,
                            Cantidad = 200.0,
                            Nombre = "Pollo a la parrilla",
                            RecetaId = 1,
                            Unidad = "Gramos"
                        },
                        new
                        {
                            Id = 3,
                            Cantidad = 50.0,
                            Nombre = "Aderezo césar",
                            RecetaId = 1,
                            Unidad = "Mililitros"
                        },
                        new
                        {
                            Id = 4,
                            Cantidad = 250.0,
                            Nombre = "Pasta espagueti",
                            RecetaId = 2,
                            Unidad = "Gramos"
                        },
                        new
                        {
                            Id = 5,
                            Cantidad = 100.0,
                            Nombre = "Crema de leche",
                            RecetaId = 2,
                            Unidad = "Mililitros"
                        },
                        new
                        {
                            Id = 6,
                            Cantidad = 1.0,
                            Nombre = "Huevo",
                            RecetaId = 2,
                            Unidad = "Unidad"
                        },
                        new
                        {
                            Id = 7,
                            Cantidad = 50.0,
                            Nombre = "Queso Parmesano",
                            RecetaId = 2,
                            Unidad = "Gramos"
                        },
                        new
                        {
                            Id = 8,
                            Cantidad = 500.0,
                            Nombre = "Tomates Frescos",
                            RecetaId = 3,
                            Unidad = "Gramos"
                        },
                        new
                        {
                            Id = 9,
                            Cantidad = 5.0,
                            Nombre = "Albahaca",
                            RecetaId = 3,
                            Unidad = "Hojas"
                        });
                });

            modelBuilder.Entity("Desafio3_DM201736_DV201086_PC191777.Models.Preparacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("RecetaId")
                        .HasColumnType("int");

                    b.Property<int>("StepOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecetaId");

                    b.ToTable("Preparaciones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Lavar la lechuga romana y cortarla en trozos",
                            RecetaId = 1,
                            StepOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Asar el pollo a la parrilla y cortarlo en tiras.",
                            RecetaId = 1,
                            StepOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Mezclar la lechuga, el pollo y el aderezo césar.",
                            RecetaId = 1,
                            StepOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Cocinar la pasta en agua hirviendo con sal.",
                            RecetaId = 2,
                            StepOrder = 1
                        },
                        new
                        {
                            Id = 5,
                            Descripcion = "Mezclar el huevo, la crema y el queso parmesano.",
                            RecetaId = 2,
                            StepOrder = 2
                        },
                        new
                        {
                            Id = 6,
                            Descripcion = "Añadir la mezcla a la pasta caliente.",
                            RecetaId = 2,
                            StepOrder = 3
                        },
                        new
                        {
                            Id = 7,
                            Descripcion = "Cortar los tomates y hervirlos hasta que se ablanden.",
                            RecetaId = 3,
                            StepOrder = 1
                        },
                        new
                        {
                            Id = 8,
                            Descripcion = "Licuar los tomates y agregar la albahaca.",
                            RecetaId = 3,
                            StepOrder = 2
                        },
                        new
                        {
                            Id = 9,
                            Descripcion = "Cocinar por 10 minutos más y servir caliente.",
                            RecetaId = 3,
                            StepOrder = 3
                        });
                });

            modelBuilder.Entity("Desafio3_DM201736_DV201086_PC191777.Models.Receta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TiempoPreparacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Recetas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Ensalada clásica con pollo, lechuga y aderezo césar.",
                            Nombre = "Ensalada César",
                            TiempoPreparacion = 20
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Pasta con salsa de crema, huevo y queso parmesano.",
                            Nombre = "Pasta Carbonara",
                            TiempoPreparacion = 30
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Sopa ligera de tomate con albahaca.",
                            Nombre = "Sopa de Tomate",
                            TiempoPreparacion = 40
                        });
                });

            modelBuilder.Entity("Desafio3_DM201736_DV201086_PC191777.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Desafio3_DM201736_DV201086_PC191777.Models.Ingrediente", b =>
                {
                    b.HasOne("Desafio3_DM201736_DV201086_PC191777.Models.Receta", "Receta")
                        .WithMany()
                        .HasForeignKey("RecetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receta");
                });

            modelBuilder.Entity("Desafio3_DM201736_DV201086_PC191777.Models.Preparacion", b =>
                {
                    b.HasOne("Desafio3_DM201736_DV201086_PC191777.Models.Receta", "Receta")
                        .WithMany()
                        .HasForeignKey("RecetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receta");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Desafio3_DM201736_DV201086_PC191777.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Desafio3_DM201736_DV201086_PC191777.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Desafio3_DM201736_DV201086_PC191777.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Desafio3_DM201736_DV201086_PC191777.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
