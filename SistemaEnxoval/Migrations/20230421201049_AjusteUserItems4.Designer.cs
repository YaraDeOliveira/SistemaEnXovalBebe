﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaEnxoval.Context;

#nullable disable

namespace SistemaEnxoval.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230421201049_AjusteUserItems4")]
    partial class AjusteUserItems4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ItemRepositoryUserRepository", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ItemRepositoryUserRepository");
                });

            modelBuilder.Entity("SistemaEnxoval.Repositories.ItemRepository", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("SistemaEnxoval.Repositories.UserItemRepository", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemsId");

                    b.HasIndex("UserId");

                    b.ToTable("UserItems");
                });

            modelBuilder.Entity("SistemaEnxoval.Repositories.UserRepository", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BabyGender")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("BabyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthForecast")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ItemRepositoryUserRepository", b =>
                {
                    b.HasOne("SistemaEnxoval.Repositories.ItemRepository", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaEnxoval.Repositories.UserRepository", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaEnxoval.Repositories.UserItemRepository", b =>
                {
                    b.HasOne("SistemaEnxoval.Repositories.ItemRepository", "Items")
                        .WithMany()
                        .HasForeignKey("ItemsId");

                    b.HasOne("SistemaEnxoval.Repositories.UserRepository", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Items");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}