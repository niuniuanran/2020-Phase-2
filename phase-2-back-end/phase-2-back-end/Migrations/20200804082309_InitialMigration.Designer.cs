﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using phase_2_back_end.Database;

namespace phase_2_back_end.Migrations
{
    [DbContext(typeof(ApplicationDatabase))]
    [Migration("20200804082309_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("phase_2_back_end.Database.Column", b =>
                {
                    b.Property<int>("ColumnID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RowID")
                        .HasColumnType("int");

                    b.Property<float>("rgb")
                        .HasColumnType("real");

                    b.HasKey("ColumnID");

                    b.HasIndex("RowID");

                    b.ToTable("Columns");
                });

            modelBuilder.Entity("phase_2_back_end.Database.Picture", b =>
                {
                    b.Property<int>("PictureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("PictureID");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("phase_2_back_end.Database.Row", b =>
                {
                    b.Property<int>("RowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PictureID")
                        .HasColumnType("int");

                    b.HasKey("RowID");

                    b.HasIndex("PictureID");

                    b.ToTable("Rows");
                });

            modelBuilder.Entity("phase_2_back_end.Database.Column", b =>
                {
                    b.HasOne("phase_2_back_end.Database.Row", null)
                        .WithMany("Columns")
                        .HasForeignKey("RowID");
                });

            modelBuilder.Entity("phase_2_back_end.Database.Row", b =>
                {
                    b.HasOne("phase_2_back_end.Database.Picture", null)
                        .WithMany("Rows")
                        .HasForeignKey("PictureID");
                });
#pragma warning restore 612, 618
        }
    }
}
