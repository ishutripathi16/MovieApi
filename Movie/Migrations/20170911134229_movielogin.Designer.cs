using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Movie.Model;

namespace Movie.Migrations
{
    [DbContext(typeof(MovieDb))]
    [Migration("20170911134229_movielogin")]
    partial class movielogin
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

            modelBuilder.Entity("Movie.Model.Login", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("confirmPassword");

                    b.Property<string>("email");

                    b.Property<string>("firstName");

                    b.Property<string>("lastName");

                    b.Property<string>("mobileNumber");

                    b.Property<string>("password");

                    b.HasKey("id");

                    b.ToTable("Logins");
                });
        }
    }
}
