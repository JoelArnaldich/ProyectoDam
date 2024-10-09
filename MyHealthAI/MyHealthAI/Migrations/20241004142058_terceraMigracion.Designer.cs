﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestConsolaBD;

#nullable disable

namespace TestConsolaBD.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241004142058_terceraMigracion")]
    partial class terceraMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestConsolaBD.AnswerIA", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Answers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("answerIAs");
                });

            modelBuilder.Entity("TestConsolaBD.DialyExercise", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExerciseHighPerfomance")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseLowPerformance")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseMediumPerformance")
                        .HasColumnType("int");

                    b.Property<int>("LiftWeights")
                        .HasColumnType("int");

                    b.Property<int>("Run")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("Walk")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("dialyExercises");
                });

            modelBuilder.Entity("TestConsolaBD.DialyWater", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("WaterLiter")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("DialyWater");
                });

            modelBuilder.Entity("TestConsolaBD.Meal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Carbohydrate")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fat")
                        .HasColumnType("int");

                    b.Property<int>("Kcal")
                        .HasColumnType("int");

                    b.Property<int>("MealTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Protein")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MealTypeID");

                    b.HasIndex("UserID");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("TestConsolaBD.MealType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MealTypes");
                });

            modelBuilder.Entity("TestConsolaBD.Objective", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("GoalWeight")
                        .HasColumnType("int");

                    b.Property<bool>("LoseWeight")
                        .HasColumnType("bit");

                    b.Property<bool>("LoseWeightWinMuscle")
                        .HasColumnType("bit");

                    b.Property<bool>("WinMuscleWinWeight")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("objectives");
                });

            modelBuilder.Entity("TestConsolaBD.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ObjectiveID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ObjectiveID")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TestConsolaBD.AnswerIA", b =>
                {
                    b.HasOne("TestConsolaBD.User", "User")
                        .WithMany("answersIA")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestConsolaBD.DialyExercise", b =>
                {
                    b.HasOne("TestConsolaBD.User", "User")
                        .WithMany("dialy_Exercises")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestConsolaBD.DialyWater", b =>
                {
                    b.HasOne("TestConsolaBD.User", "User")
                        .WithMany("DialyWater")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestConsolaBD.Meal", b =>
                {
                    b.HasOne("TestConsolaBD.MealType", "MealType")
                        .WithMany("Meals")
                        .HasForeignKey("MealTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestConsolaBD.User", "User")
                        .WithMany("Meals")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MealType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestConsolaBD.User", b =>
                {
                    b.HasOne("TestConsolaBD.Objective", "Objective")
                        .WithOne("User")
                        .HasForeignKey("TestConsolaBD.User", "ObjectiveID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objective");
                });

            modelBuilder.Entity("TestConsolaBD.MealType", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("TestConsolaBD.Objective", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("TestConsolaBD.User", b =>
                {
                    b.Navigation("DialyWater");

                    b.Navigation("Meals");

                    b.Navigation("answersIA");

                    b.Navigation("dialy_Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
