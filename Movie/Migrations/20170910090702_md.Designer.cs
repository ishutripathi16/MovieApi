using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Movie.Model;

namespace Movie.Migrations
{
    [DbContext(typeof(MovieDb))]
    [Migration("20170910090702_md")]
    partial class md
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Movie.Model.FavMovie", b =>
                {
                    b.Property<int>("movieid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("daterelease");

                    b.Property<string>("moviename");

                    b.Property<string>("overview");

                    b.Property<string>("posterpath");

                    b.HasKey("movieid");

                    b.ToTable("MovieTable");
                });
        }
    }
}
