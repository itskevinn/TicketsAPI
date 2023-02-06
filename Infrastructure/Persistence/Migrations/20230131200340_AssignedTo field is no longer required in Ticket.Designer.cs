﻿// <auto-generated />
using System;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(TicketsContext))]
    [Migration("20230131200340_AssignedTo field is no longer required in Ticket")]
    partial class AssignedTofieldisnolongerrequiredinTicket
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.HasSequence("sq_ticket_code");

            modelBuilder.Entity("Domain.Entity.Attachment", b =>
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
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.Property<Guid?>("TicketDetailId")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("TicketDetailId");

                    b.ToTable("Attachment");
                });

            modelBuilder.Entity("Domain.Entity.MenuItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(4383));

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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(4888));

                    b.Property<int>("Order")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("RouterLink")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("Id");

                    b.ToTable("MenuItem");

                    b.HasData(
                        new
                        {
                            Id = new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(2023, 1, 31, 15, 3, 39, 543, DateTimeKind.Local).AddTicks(55),
                            Icon = "fa-solid fa-plane-departure",
                            Label = "Tickets",
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Order = 1,
                            RouterLink = "tickets",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(2023, 1, 31, 15, 3, 39, 543, DateTimeKind.Local).AddTicks(84),
                            Icon = "fa-solid fa-plane-departure",
                            Label = "Usuarios",
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Order = 2,
                            RouterLink = "users",
                            Status = true
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(5304));

                    b.Property<Guid>("Id")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(5769));

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

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
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            RoleId = new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"),
                            MenuItemId = new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb8e"),
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            RoleId = new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"),
                            MenuItemId = new Guid("504731d4-0a34-41d5-9b0b-0611b3f76098"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb8b"),
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            RoleId = new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"),
                            MenuItemId = new Guid("504731d4-0a34-41d5-9b0b-0611b3f76096"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb8a"),
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(6178));

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(6592));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf1de1aa-fc78-4b92-6942-08da36131198"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleName = "Admin",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleName = "User",
                            Status = true
                        });
                });

            modelBuilder.Entity("Domain.Entity.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<DateTime>("AllegedSolveDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("AssignedTo")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Code")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("GeneratedBy")
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

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.Property<Guid>("TicketStatusId")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("TicketStatusId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("Domain.Entity.TicketDetail", b =>
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
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.Property<Guid>("TicketId")
                        .HasColumnType("RAW(16)");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketDetail");
                });

            modelBuilder.Entity("Domain.Entity.TicketStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("RAW(16)");

                    b.Property<string>("BackgroundColor")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(7011));

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(7372));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("Id");

                    b.ToTable("TicketStatus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("504731d4-0a34-41d5-9b0b-0611b3f76777"),
                            BackgroundColor = "#c8e6c9",
                            Color = "#256029",
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(3850),
                            Description = "Estado del ticket resuelto",
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Resuelto",
                            Status = true
                        });
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(7736));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(8040));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR2(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

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
                            Email = "kvnpntn@gmail.com",
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kevin Pontón",
                            Password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918",
                            Status = true,
                            Username = "Admin"
                        },
                        new
                        {
                            Id = new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb6f"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "keviinpn2@gmail.com",
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Usuario",
                            Password = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                            Status = true,
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(8541));

                    b.Property<Guid>("Id")
                        .HasColumnType("RAW(16)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("LastModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP(7)")
                        .HasDefaultValue(new DateTime(2023, 1, 31, 15, 3, 39, 545, DateTimeKind.Local).AddTicks(8934));

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

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
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            RoleId = new Guid("4a77cee4-5cfa-4c90-b41a-08da36159111"),
                            UserId = new Guid("c82a18c6-e473-4976-5f2e-08da35e4eb6f"),
                            CreatedBy = "AutoGenerated",
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = new Guid("bf1de1aa-fc78-4b92-6942-09da3e131298"),
                            LastModifiedBy = "AutoGenerated",
                            LastModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        });
                });

            modelBuilder.Entity("Domain.Entity.Attachment", b =>
                {
                    b.HasOne("Domain.Entity.TicketDetail", null)
                        .WithMany("Attachments")
                        .HasForeignKey("TicketDetailId");
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

            modelBuilder.Entity("Domain.Entity.Ticket", b =>
                {
                    b.HasOne("Domain.Entity.TicketStatus", "TicketStatus")
                        .WithMany()
                        .HasForeignKey("TicketStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TicketStatus");
                });

            modelBuilder.Entity("Domain.Entity.TicketDetail", b =>
                {
                    b.HasOne("Domain.Entity.Ticket", null)
                        .WithMany("TicketDetails")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("Domain.Entity.Ticket", b =>
                {
                    b.Navigation("TicketDetails");
                });

            modelBuilder.Entity("Domain.Entity.TicketDetail", b =>
                {
                    b.Navigation("Attachments");
                });

            modelBuilder.Entity("Domain.Entity.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
