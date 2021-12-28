﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(EventsContext))]
    [Migration("20211226131950_SeedUserOrganizerEventData")]
    partial class SeedUserOrganizerEventData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccess.Models.City", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Name = "Munich"
                        },
                        new
                        {
                            Name = "Berlin"
                        },
                        new
                        {
                            Name = "Cologne"
                        },
                        new
                        {
                            Name = "Frankfurt"
                        },
                        new
                        {
                            Name = "Hamburg"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatePlanned")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int?>("MaxParticipants")
                        .HasColumnType("int");

                    b.Property<int?>("MinAge")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OrganizerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("OrganizerId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatePlanned = new DateTime(2022, 2, 1, 17, 30, 0, 0, DateTimeKind.Unspecified),
                            Description = "You are new in town? Join us and meet like-minded new people!",
                            Image = "path/to/image.jpg",
                            LocationId = 1,
                            MaxParticipants = 20,
                            MinAge = 16,
                            Name = "New in town",
                            OrganizerId = 1
                        });
                });

            modelBuilder.Entity("DataAccess.Models.EventTag", b =>
                {
                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("TagId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("EventId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("EventTag");
                });

            modelBuilder.Entity("DataAccess.Models.EventUser", b =>
                {
                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("EventId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("EventUser");
                });

            modelBuilder.Entity("DataAccess.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Street")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CityName");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Munich",
                            HouseNumber = "5A",
                            PostalCode = "80135",
                            Street = "Beerstreet",
                            Title = "Beerhall"
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Munich",
                            HouseNumber = "10",
                            PostalCode = "81035",
                            Street = "Beerstreet"
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Munich",
                            HouseNumber = "101",
                            PostalCode = "80031",
                            Street = "Gardenstreet"
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Berlin",
                            HouseNumber = "12",
                            PostalCode = "12141",
                            Street = "Veggiestreet",
                            Title = "The Green One"
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Berlin",
                            HouseNumber = "1",
                            PostalCode = "11011",
                            Street = "Park Plaza"
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Cologne",
                            HouseNumber = "3",
                            PostalCode = "12345",
                            Street = "Carnevalstreet",
                            Title = "Partyhouse"
                        },
                        new
                        {
                            Id = 7,
                            CityName = "Hamburg",
                            HouseNumber = "18",
                            PostalCode = "72657",
                            Street = "Some"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Organizer", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Passward")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Organizer");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Passward = "mypw1"
                        },
                        new
                        {
                            UserId = 2,
                            Passward = "somepw2"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Tag", b =>
                {
                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TagName");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            TagName = "socialize"
                        },
                        new
                        {
                            TagName = "learn"
                        },
                        new
                        {
                            TagName = "connect"
                        },
                        new
                        {
                            TagName = "dinner"
                        },
                        new
                        {
                            TagName = "breakfast"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthdate")
                        .HasPrecision(3)
                        .HasColumnType("datetime2(3)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(1989, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "max@test.com",
                            FirstName = "Max",
                            LastName = "Schwarz"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(1988, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "manuel@test.com",
                            FirstName = "Manuel",
                            LastName = "Lorenz"
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = new DateTime(1986, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "julie@test.com",
                            FirstName = "Julie",
                            LastName = "Barnes"
                        },
                        new
                        {
                            Id = 4,
                            Birthdate = new DateTime(1982, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "michael@test.com",
                            FirstName = "Michael",
                            LastName = "Smith"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Event", b =>
                {
                    b.HasOne("DataAccess.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Organizer", null)
                        .WithMany()
                        .HasForeignKey("OrganizerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.EventTag", b =>
                {
                    b.HasOne("DataAccess.Models.Event", null)
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.EventUser", b =>
                {
                    b.HasOne("DataAccess.Models.Event", null)
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Location", b =>
                {
                    b.HasOne("DataAccess.Models.City", null)
                        .WithMany()
                        .HasForeignKey("CityName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.Organizer", b =>
                {
                    b.HasOne("DataAccess.Models.User", null)
                        .WithOne()
                        .HasForeignKey("DataAccess.Models.Organizer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
