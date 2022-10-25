﻿// <auto-generated />
using System;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(TicketsContext))]
    [Migration("20221023200129_Ticked code generated auto")]
    partial class Tickedcodegeneratedauto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entity.MenuItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR2(30)");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR2(30)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("Order")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("RouterLink")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.HasKey("Id");

                    b.ToTable("MenuItem");

                    b.HasData(
                        new
                        {
                            Id = new Guid("012fff70-84e2-4962-84a3-3b7833bb71fb"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Icon = "fa-solid fa-house",
                            Label = "Inicio",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Order = 0,
                            RouterLink = "home"
                        },
                        new
                        {
                            Id = new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Icon = "fa-solid fa-plane-departure",
                            Label = "Tickets",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Order = 1,
                            RouterLink = "tickets"
                        });
                });

            modelBuilder.Entity("Domain.Entity.MenuItemRole", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("RAW(16)");

                    b.Property<Guid>("MenuItemId")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<Guid>("Id")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("RoleId", "MenuItemId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("MenuItemRole");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"),
                            MenuItemId = new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("c82a18c6-e473-4976-5f2e-08da35e4ebfe"),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoleId = new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"),
                            MenuItemId = new Guid("012fff70-84e2-4962-84a3-3b7833bb71fb"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb8e"),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoleId = new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"),
                            MenuItemId = new Guid("012fff70-84e2-4962-84a3-3b7833bb71fb"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb8b"),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoleId = new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"),
                            MenuItemId = new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb8a"),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Domain.Entity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleName = "User"
                        });
                });

            modelBuilder.Entity("Domain.Entity.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<DateTime>("AllegedSolveDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("GeneratedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("SolvedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.HasKey("Id");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("Domain.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR2(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("NVARCHAR2(15)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4a77cee4-5cfa-4c90-b41a-08da36159120"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kevin Pontón",
                            Password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918",
                            Username = "Admin"
                        },
                        new
                        {
                            Id = new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb6f"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Usuario",
                            Password = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                            Username = "User"
                        });
                });

            modelBuilder.Entity("Domain.Entity.UserRole", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("RAW(16)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<Guid>("Id")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"),
                            UserId = new Guid("4a77cee4-5cfa-4c90-b41a-08da36159120"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("bf1de1aa-fc78-4b92-6942-09da36131298"),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            RoleId = new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"),
                            UserId = new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb6f"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("bf1de1aa-fc78-4b92-6942-09da3e131298"),
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Domain.Entity.MenuItemRole", b =>
                {
                    b.HasOne("Domain.Entity.MenuItem", "MenuItem")
                        .WithMany("MenuItemRoles")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Role", "Role")
                        .WithMany("RoleMenuItems")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Entity.UserRole", b =>
                {
                    b.HasOne("Domain.Entity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entity.MenuItem", b =>
                {
                    b.Navigation("MenuItemRoles");
                });

            modelBuilder.Entity("Domain.Entity.Role", b =>
                {
                    b.Navigation("RoleMenuItems");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Domain.Entity.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
