﻿using Carrefas.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Carrefas.Data.Context
{
    public class CarrefasContext : DbContext
    {
        public CarrefasContext(DbContextOptions<CarrefasContext> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Verificar o API Fluent que foi criado e caso alguma propriedade não estiver setado ColumnType (tipo da coluna)
            //Por default colocar a propriedade como string de 100 caracteres (varchar(100))
            foreach (var property in modelBuilder.Model.GetEntityTypes()
               .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string)))) property.SetColumnType("varchar(100)");


            //Obter todo o mapeamento realizado utilizando
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarrefasContext).Assembly);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
