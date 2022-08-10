﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoTask.Models;

#nullable disable

namespace ASPbackend.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220728103332_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.5.22302.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectTodo", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("TodoId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId", "TodoId");

                    b.HasIndex("TodoId");

                    b.ToTable("ProjectTodo");
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Account");
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.Priority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PriorityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TodoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Priority");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PriorityName = "Срочно",
                            TodoId = 0
                        },
                        new
                        {
                            Id = 2,
                            PriorityName = "В обычном темпе",
                            TodoId = 0
                        },
                        new
                        {
                            Id = 3,
                            PriorityName = "Можно не торопиться",
                            TodoId = 0
                        });
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartData")
                        .HasColumnType("datetime2");

                    b.Property<int>("TodoId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeadLine = new DateTime(2078, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "пизда",
                            StartData = new DateTime(2022, 7, 28, 12, 33, 28, 913, DateTimeKind.Local).AddTicks(1071),
                            TodoId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TodoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StatusName = "В ожидании",
                            TodoId = 0
                        },
                        new
                        {
                            Id = 2,
                            StatusName = "В работе",
                            TodoId = 0
                        },
                        new
                        {
                            Id = 3,
                            StatusName = "Завершено",
                            TodoId = 0
                        });
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndData")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameTask")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PriorityId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartData")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PriorityId");

                    b.HasIndex("StatusId");

                    b.ToTable("Todo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "dsdsd",
                            EndData = new DateTime(2077, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameTask = "хуй",
                            PriorityId = 1,
                            ProjectId = 1,
                            StartData = new DateTime(2022, 7, 28, 12, 33, 28, 913, DateTimeKind.Local).AddTicks(1098),
                            StatusId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "dsdsd",
                            EndData = new DateTime(2077, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NameTask = "хуй",
                            PriorityId = 1,
                            ProjectId = 1,
                            StartData = new DateTime(2022, 7, 28, 12, 33, 28, 913, DateTimeKind.Local).AddTicks(1101),
                            StatusId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("TodoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 0,
                            Email = "dsdsd",
                            Name = "dsds",
                            ProjectId = 1,
                            TodoId = 1
                        });
                });

            modelBuilder.Entity("TodoUser", b =>
                {
                    b.Property<int>("TodoId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TodoId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("TodoUser");
                });

            modelBuilder.Entity("ProjectTodo", b =>
                {
                    b.HasOne("ToDoTaskServer.Models.Entity.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToDoTaskServer.Models.Entity.Todo", null)
                        .WithMany()
                        .HasForeignKey("TodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.HasOne("ToDoTaskServer.Models.Entity.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToDoTaskServer.Models.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.Account", b =>
                {
                    b.HasOne("ToDoTaskServer.Models.Entity.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("ToDoTaskServer.Models.Entity.Account", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.Todo", b =>
                {
                    b.HasOne("ToDoTaskServer.Models.Entity.Priority", "Priority")
                        .WithMany("Todo")
                        .HasForeignKey("PriorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToDoTaskServer.Models.Entity.Status", "Status")
                        .WithMany("Todo")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Priority");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("TodoUser", b =>
                {
                    b.HasOne("ToDoTaskServer.Models.Entity.Todo", null)
                        .WithMany()
                        .HasForeignKey("TodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToDoTaskServer.Models.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.Priority", b =>
                {
                    b.Navigation("Todo");
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.Status", b =>
                {
                    b.Navigation("Todo");
                });

            modelBuilder.Entity("ToDoTaskServer.Models.Entity.User", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}