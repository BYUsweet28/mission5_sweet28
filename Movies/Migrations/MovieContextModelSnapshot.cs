﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Models;

namespace Movies.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Movies.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Televeision"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("Movies.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryID = 1,
                            Director = "Jared Hess",
                            Edited = false,
                            LentTo = "Max",
                            Notes = "Filmed in Idaho",
                            Rating = "PG",
                            Title = "Napoleon Dynamite",
                            Year = 2004
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryID = 2,
                            Director = "Chris Columbus",
                            Edited = true,
                            Rating = "PG",
                            Title = "Home Alone",
                            Year = 1990
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryID = 3,
                            Director = "Steven Speilberg",
                            Edited = true,
                            Notes = "Watch out for velociraptors",
                            Rating = "PG-13",
                            Title = "Jurrasic Park",
                            Year = 1993
                        });
                });

            modelBuilder.Entity("Movies.Models.MovieResponse", b =>
                {
                    b.HasOne("Movies.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
