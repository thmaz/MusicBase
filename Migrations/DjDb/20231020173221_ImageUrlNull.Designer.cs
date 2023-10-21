﻿// <auto-generated />
using System;
using AppB2C2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppB2C2.Migrations.DjDb
{
    [DbContext(typeof(DjDbContext))]
    [Migration("20231020173221_ImageUrlNull")]
    partial class ImageUrlNull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppB2C2.Models.Domain.ItemTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemTags");
                });

            modelBuilder.Entity("AppB2C2.Models.Domain.MusicItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("ItemValue")
                        .HasColumnType("real");

                    b.Property<string>("UrlHandle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MusicItems");
                });

            modelBuilder.Entity("ItemTagMusicItem", b =>
                {
                    b.Property<Guid>("ItemTagsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MusicItemsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemTagsId", "MusicItemsId");

                    b.HasIndex("MusicItemsId");

                    b.ToTable("ItemTagMusicItem");
                });

            modelBuilder.Entity("ItemTagMusicItem", b =>
                {
                    b.HasOne("AppB2C2.Models.Domain.ItemTag", null)
                        .WithMany()
                        .HasForeignKey("ItemTagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppB2C2.Models.Domain.MusicItem", null)
                        .WithMany()
                        .HasForeignKey("MusicItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
