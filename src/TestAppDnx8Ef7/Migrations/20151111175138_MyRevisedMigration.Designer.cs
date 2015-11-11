using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TestAppDnx8Ef7.Models;

namespace TestAppDnx8Ef7.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20151111175138_MyRevisedMigration")]
    partial class MyRevisedMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta8-15964")
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestAppDnx8Ef7.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("BlogId");
                });

            modelBuilder.Entity("TestAppDnx8Ef7.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BlogId");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("PostId");
                });

            modelBuilder.Entity("TestAppDnx8Ef7.Models.Post", b =>
                {
                    b.HasOne("TestAppDnx8Ef7.Models.Blog")
                        .WithMany()
                        .ForeignKey("BlogId");
                });
        }
    }
}
