using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DungonMasterToolsRepository;

namespace DungonMasterToolsRepository.Migrations
{
    [DbContext(typeof(DungonMasterToolsDbContext))]
    [Migration("20170206035332_AddItemModel")]
    partial class AddItemModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DungeonMasterTools.Models.ItemModel", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });
        }
    }
}
