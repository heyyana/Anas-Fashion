﻿using Anas_Fashion.Models;
using Microsoft.EntityFrameworkCore;

namespace Anas_Fashion.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<FornecedorModel> Fornecedores { get; set; }
        public DbSet<VendedorModel> Vendedores { get; set; }
        public DbSet<ClienteModel> Clientes { get; set;}
    }
}
