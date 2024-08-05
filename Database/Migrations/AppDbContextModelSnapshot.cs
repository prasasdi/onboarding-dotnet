﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using onboarding_backend.Database;

#nullable disable

namespace onboarding_backend.Database.MIgrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("onboarding_backend.Database.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Overview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PlayUntil")
                        .HasColumnType("datetime2");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.MovieSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudioId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("StudioId");

                    b.ToTable("MovieSchedules");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.MovieTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("TagId");

                    b.ToTable("MovieTags");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<double>("TotalItemPrice")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Snapshots")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SubTotalPrice")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MovieScheduleId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.Studio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("SeatCapacity")
                        .HasColumnType("int");

                    b.Property<int>("StudioNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Studios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 17, DateTimeKind.Local).AddTicks(8490),
                            SeatCapacity = 10,
                            StudioNumber = 1,
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 17, DateTimeKind.Local).AddTicks(8502)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 17, DateTimeKind.Local).AddTicks(8504),
                            SeatCapacity = 15,
                            StudioNumber = 2,
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 17, DateTimeKind.Local).AddTicks(8505)
                        });
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(7996),
                            Name = "Action",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8001)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8023),
                            Name = "Comedy",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8024)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8026),
                            Name = "Drama",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8026)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8028),
                            Name = "Horror",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8028)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8029),
                            Name = "Romance",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8030)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8031),
                            Name = "Science Fiction",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8032)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8034),
                            Name = "Fantasy",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8034)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8035),
                            Name = "Thriller",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8036)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8037),
                            Name = "Mystery",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8038)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8039),
                            Name = "Documentary",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8040)
                        });
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avatar = "https://static-00.iconduck.com/assets.00/avatar-default-symbolic-icon-479x512-n8sg74wg.png",
                            CreatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(7504),
                            Email = "admin@admin.com",
                            IsAdmin = true,
                            Name = "Admin",
                            Password = "$2a$11$idOaeNaUzZP9be4lVSbsyOUdEuDudetBycxGuHiKl0I3jqU0/UPD6",
                            UpdatedAt = new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(7520)
                        });
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.MovieSchedule", b =>
                {
                    b.HasOne("onboarding_backend.Database.Entities.Movie", "Movie")
                        .WithMany("Schedules")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("onboarding_backend.Database.Entities.Studio", "Studio")
                        .WithMany("MovieSchedules")
                        .HasForeignKey("StudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.MovieTag", b =>
                {
                    b.HasOne("onboarding_backend.Database.Entities.Movie", "Movie")
                        .WithMany("Tags")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("onboarding_backend.Database.Entities.Tag", "Tag")
                        .WithMany("MovieTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.Order", b =>
                {
                    b.HasOne("onboarding_backend.Database.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.OrderItem", b =>
                {
                    b.HasOne("onboarding_backend.Database.Entities.MovieSchedule", "MovieSchedule")
                        .WithMany()
                        .HasForeignKey("MovieScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("onboarding_backend.Database.Entities.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovieSchedule");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.Movie", b =>
                {
                    b.Navigation("Schedules");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.Studio", b =>
                {
                    b.Navigation("MovieSchedules");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.Tag", b =>
                {
                    b.Navigation("MovieTags");
                });

            modelBuilder.Entity("onboarding_backend.Database.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
