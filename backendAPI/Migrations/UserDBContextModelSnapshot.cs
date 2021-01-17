﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backendAPI.Models;

namespace backendAPI.Migrations
{
    [DbContext(typeof(UserDBContext))]
    partial class UserDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("backendAPI.Models.User", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("joinedDate")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("team")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("name");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
