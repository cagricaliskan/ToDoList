﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoList;

namespace ToDoList.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20210111130030_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ToDoList.Models.Todotask", b =>
                {
                    b.Property<int>("TodotaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TodotaskName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isDone")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("TodotaskID");

                    b.ToTable("todotasks");
                });
#pragma warning restore 612, 618
        }
    }
}
