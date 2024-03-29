﻿// <auto-generated />
using Boteco32.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Boteco32.Migrations
{
    [DbContext(typeof(Boteco32Context))]
    partial class Boteco32ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Boteco32.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasColumnName("endereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("senha");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Boteco32.Models.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdPedido")
                        .HasColumnType("int")
                        .HasColumnName("idPedido");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnName("idProduto");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("quantidade");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdPedido" }, "IX_ItemPedido_idPedido");

                    b.HasIndex(new[] { "IdProduto" }, "IX_ItemPedido_idProduto");

                    b.ToTable("ItemPedido", (string)null);
                });

            modelBuilder.Entity("Boteco32.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("data");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("idCliente");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("numero");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("valorTotal");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdCliente" }, "IX_Pedido_idCliente");

                    b.ToTable("Pedido", (string)null);
                });

            modelBuilder.Entity("Boteco32.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Codigo")
                        .HasColumnType("int")
                        .HasColumnName("codigo");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("preco");

                    b.Property<int>("SaldoEstoque")
                        .HasColumnType("int")
                        .HasColumnName("saldoEstoque");

                    b.HasKey("Id");

                    b.ToTable("Produto", (string)null);
                });

            modelBuilder.Entity("Boteco32.Models.ItemPedido", b =>
                {
                    b.HasOne("Boteco32.Models.Pedido", "IdPedidoNavigation")
                        .WithMany("ItemPedidos")
                        .HasForeignKey("IdPedido")
                        .IsRequired()
                        .HasConstraintName("FK_ItemPedido_Pedido");

                    b.HasOne("Boteco32.Models.Produto", "IdProdutoNavigation")
                        .WithMany("ItemPedidos")
                        .HasForeignKey("IdProduto")
                        .IsRequired()
                        .HasConstraintName("FK_ItemPedido_Produto");

                    b.Navigation("IdPedidoNavigation");

                    b.Navigation("IdProdutoNavigation");
                });

            modelBuilder.Entity("Boteco32.Models.Pedido", b =>
                {
                    b.HasOne("Boteco32.Models.Cliente", "IdClienteNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_Pedido_Cliente");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("Boteco32.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Boteco32.Models.Pedido", b =>
                {
                    b.Navigation("ItemPedidos");
                });

            modelBuilder.Entity("Boteco32.Models.Produto", b =>
                {
                    b.Navigation("ItemPedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
