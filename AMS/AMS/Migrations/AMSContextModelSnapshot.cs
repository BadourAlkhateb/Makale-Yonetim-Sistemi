﻿// <auto-generated />
using System;
using AMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AMS.Migrations
{
    [DbContext(typeof(AMSContext))]
    partial class AMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Turkish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AMS.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorFirstName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("AuthorLastName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("AuthorMail")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("AuthorNotes")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AuthorPhone")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("FileName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Title")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("AMS.Entities.RefereeArticle", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("RefereeId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("Score")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("smalldatetime");

                    b.HasKey("ArticleId", "RefereeId")
                        .HasName("PK__RefereeA__2C24FEBAA9F94638");

                    b.HasIndex("RefereeId");

                    b.ToTable("RefereeArticle");
                });

            modelBuilder.Entity("AMS.Entities.SystemUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Mail")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Pass")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Role")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Title")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("SystemUser");
                });

            modelBuilder.Entity("AMS.Entities.RefereeArticle", b =>
                {
                    b.HasOne("AMS.Entities.Article", "Article")
                        .WithMany("RefereeArticles")
                        .HasForeignKey("ArticleId")
                        .HasConstraintName("FK__RefereeAr__Artic__145C0A3F")
                        .IsRequired();

                    b.HasOne("AMS.Entities.SystemUser", "Referee")
                        .WithMany("RefereeArticles")
                        .HasForeignKey("RefereeId")
                        .HasConstraintName("FK__RefereeAr__Refer__15502E78")
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Referee");
                });

            modelBuilder.Entity("AMS.Entities.Article", b =>
                {
                    b.Navigation("RefereeArticles");
                });

            modelBuilder.Entity("AMS.Entities.SystemUser", b =>
                {
                    b.Navigation("RefereeArticles");
                });
#pragma warning restore 612, 618
        }
    }
}
