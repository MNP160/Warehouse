﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehouseManagement.Models;

namespace WarehouseManagement.Migrations.Store
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WarehouseManagement.StorefrontModels.storeCathegories", b =>
                {
                    b.Property<int>("storeCathegoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("storeCathegoryId");

                    b.ToTable("storeCathegories");
                });

            modelBuilder.Entity("WarehouseManagement.StorefrontModels.storeItems", b =>
                {
                    b.Property<int>("storeItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int?>("cathegoriesstoreCathegoryId");

                    b.HasKey("storeItemId");

                    b.HasIndex("cathegoriesstoreCathegoryId");

                    b.ToTable("storeItems");
                });

            modelBuilder.Entity("WarehouseManagement.StorefrontModels.storeItems", b =>
                {
                    b.HasOne("WarehouseManagement.StorefrontModels.storeCathegories", "cathegories")
                        .WithMany("items")
                        .HasForeignKey("cathegoriesstoreCathegoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
