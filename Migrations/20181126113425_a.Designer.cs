﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebEditor.DataAccessLayer;

namespace WebEditor.Migrations
{
    [DbContext(typeof(MulitDbDal))]
    [Migration("20181126113425_a")]
    partial class a
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("WebEditor.Models.ArtCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .HasMaxLength(30);

                    b.HasKey("id");

                    b.ToTable("ArtCategorys");
                });

            modelBuilder.Entity("WebEditor.Models.Article", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("artCategoryId");

                    b.Property<string>("description")
                        .HasMaxLength(10000);

                    b.Property<string>("name")
                        .HasMaxLength(30);

                    b.Property<int>("priority");

                    b.HasKey("id");

                    b.HasIndex("artCategoryId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("WebEditor.Models.ArtRefImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("UImageid");

                    b.Property<int>("articleId");

                    b.Property<string>("url")
                        .HasMaxLength(300);

                    b.HasKey("id");

                    b.HasIndex("UImageid");

                    b.HasIndex("articleId");

                    b.ToTable("ArtRefImages");
                });

            modelBuilder.Entity("WebEditor.Models.Company", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("mainBusiness")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("userBaseId");

                    b.HasKey("id");

                    b.HasIndex("userBaseId")
                        .IsUnique();

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("WebEditor.Models.Industry", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("companyId");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.HasIndex("companyId");

                    b.ToTable("Industrys");
                });

            modelBuilder.Entity("WebEditor.Models.ProdCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.ToTable("ProdCategorys");
                });

            modelBuilder.Entity("WebEditor.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description")
                        .HasMaxLength(200);

                    b.Property<decimal>("discount");

                    b.Property<string>("image_url")
                        .HasMaxLength(200);

                    b.Property<string>("name")
                        .HasMaxLength(30);

                    b.Property<decimal>("price");

                    b.Property<int>("prodCategoryId");

                    b.HasKey("id");

                    b.HasIndex("prodCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebEditor.Models.UArtCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("artCategoryId");

                    b.Property<int>("userBaseId");

                    b.HasKey("id");

                    b.HasIndex("artCategoryId");

                    b.HasIndex("userBaseId");

                    b.ToTable("UArtCategroys");
                });

            modelBuilder.Entity("WebEditor.Models.UFolwArtCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtCategoryId");

                    b.Property<int>("userBaseId");

                    b.HasKey("id");

                    b.HasIndex("ArtCategoryId");

                    b.HasIndex("userBaseId");

                    b.ToTable("UFolwArtCategorys");
                });

            modelBuilder.Entity("WebEditor.Models.UFolwProdCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("prodCategoryId");

                    b.Property<int>("userBaseId");

                    b.HasKey("id");

                    b.HasIndex("prodCategoryId");

                    b.HasIndex("userBaseId");

                    b.ToTable("UFolwProdCategorys");
                });

            modelBuilder.Entity("WebEditor.Models.UImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("url")
                        .HasMaxLength(300);

                    b.HasKey("id");

                    b.ToTable("UImages");
                });

            modelBuilder.Entity("WebEditor.Models.UProdCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("prodCategoryId");

                    b.Property<int>("userBaseId");

                    b.HasKey("id");

                    b.HasIndex("prodCategoryId");

                    b.HasIndex("userBaseId");

                    b.ToTable("UProdCategorys");
                });

            modelBuilder.Entity("WebEditor.Models.UserBase", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("openid")
                        .HasMaxLength(50);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("phone")
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("UserBases");
                });

            modelBuilder.Entity("WebEditor.Models.UserDetial", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("nickname")
                        .HasMaxLength(10);

                    b.Property<string>("openid")
                        .HasMaxLength(50);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("phone")
                        .HasMaxLength(20);

                    b.Property<string>("photo")
                        .HasMaxLength(50);

                    b.Property<string>("signatureline")
                        .HasMaxLength(200);

                    b.Property<int>("userBaseId");

                    b.HasKey("id");

                    b.HasIndex("userBaseId")
                        .IsUnique();

                    b.ToTable("UserDetials");
                });

            modelBuilder.Entity("WebEditor.Models.Article", b =>
                {
                    b.HasOne("WebEditor.Models.ArtCategory", "artCategory")
                        .WithMany("articles")
                        .HasForeignKey("artCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.ArtRefImage", b =>
                {
                    b.HasOne("WebEditor.Models.UImage")
                        .WithMany("artRefImage")
                        .HasForeignKey("UImageid");

                    b.HasOne("WebEditor.Models.Article", "article")
                        .WithMany("artRefImages")
                        .HasForeignKey("articleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.Company", b =>
                {
                    b.HasOne("WebEditor.Models.UserBase")
                        .WithOne("company")
                        .HasForeignKey("WebEditor.Models.Company", "userBaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.Industry", b =>
                {
                    b.HasOne("WebEditor.Models.Company", "company")
                        .WithMany("industrys")
                        .HasForeignKey("companyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.Product", b =>
                {
                    b.HasOne("WebEditor.Models.ProdCategory", "prodCategory")
                        .WithMany("products")
                        .HasForeignKey("prodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.UArtCategory", b =>
                {
                    b.HasOne("WebEditor.Models.ArtCategory", "artCategory")
                        .WithMany()
                        .HasForeignKey("artCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebEditor.Models.UserBase", "userBase")
                        .WithMany("uArtCategorys")
                        .HasForeignKey("userBaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.UFolwArtCategory", b =>
                {
                    b.HasOne("WebEditor.Models.ArtCategory", "artCategory")
                        .WithMany("uFolwArtCategorys")
                        .HasForeignKey("ArtCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebEditor.Models.UserBase", "userBase")
                        .WithMany("uFolwArtCategorys")
                        .HasForeignKey("userBaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.UFolwProdCategory", b =>
                {
                    b.HasOne("WebEditor.Models.ProdCategory", "prodCategory")
                        .WithMany("uFolwProdCategorys")
                        .HasForeignKey("prodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebEditor.Models.UserBase", "userBase")
                        .WithMany("uFolwProdCategorys")
                        .HasForeignKey("userBaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.UProdCategory", b =>
                {
                    b.HasOne("WebEditor.Models.ProdCategory", "prodCategory")
                        .WithMany("uProdCategorys")
                        .HasForeignKey("prodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebEditor.Models.UserBase", "userBase")
                        .WithMany("uProdCategorys")
                        .HasForeignKey("userBaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebEditor.Models.UserDetial", b =>
                {
                    b.HasOne("WebEditor.Models.UserBase", "userBase")
                        .WithOne("userDetial")
                        .HasForeignKey("WebEditor.Models.UserDetial", "userBaseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
