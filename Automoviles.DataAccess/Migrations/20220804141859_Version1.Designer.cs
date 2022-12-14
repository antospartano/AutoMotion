// <auto-generated />
using System;
using Automoviles.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Automoviles.DataAccess.Migrations
{
    [DbContext(typeof(AutoDbContext))]
    [Migration("20220804141859_Version1")]
    partial class Version1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Automoviles.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Colores");
                });

            modelBuilder.Entity("Automoviles.Models.Combustible", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Combustibles");
                });

            modelBuilder.Entity("Automoviles.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Automoviles.Models.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("Automoviles.Models.Seguro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Seguros");
                });

            modelBuilder.Entity("Automoviles.Models.Tipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Tipos");
                });

            modelBuilder.Entity("Automoviles.Models.Transmision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Transmisiones");
                });

            modelBuilder.Entity("Automoviles.Models.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColorId");

                    b.Property<int?>("ColorId1")
                        .HasColumnType("int");

                    b.Property<string>("CombustibleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CombustibleId");

                    b.Property<int?>("CombustibleId1")
                        .HasColumnType("int");

                    b.Property<string>("FechaId")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)")
                        .HasColumnName("Año");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int")
                        .HasColumnName("MarcaId");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Modelo");

                    b.Property<string>("PaisId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PaisId");

                    b.Property<int?>("PaisId1")
                        .HasColumnType("int");

                    b.Property<string>("Precio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PrecioId");

                    b.Property<string>("SeguroId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SeguroId");

                    b.Property<int?>("SeguroId1")
                        .HasColumnType("int");

                    b.Property<string>("TipoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoId");

                    b.Property<int?>("TipoId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId1");

                    b.HasIndex("CombustibleId1");

                    b.HasIndex("MarcaId");

                    b.HasIndex("PaisId1");

                    b.HasIndex("SeguroId1");

                    b.HasIndex("TipoId1");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Automoviles.Models.Vehiculo", b =>
                {
                    b.HasOne("Automoviles.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId1");

                    b.HasOne("Automoviles.Models.Combustible", "Combustible")
                        .WithMany()
                        .HasForeignKey("CombustibleId1");

                    b.HasOne("Automoviles.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Automoviles.Models.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId1");

                    b.HasOne("Automoviles.Models.Seguro", "Seguro")
                        .WithMany()
                        .HasForeignKey("SeguroId1");

                    b.HasOne("Automoviles.Models.Tipo", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoId1");

                    b.Navigation("Color");

                    b.Navigation("Combustible");

                    b.Navigation("Marca");

                    b.Navigation("Pais");

                    b.Navigation("Seguro");

                    b.Navigation("Tipo");
                });
#pragma warning restore 612, 618
        }
    }
}
