﻿using Microsoft.EntityFrameworkCore;
using Practica02.Model;

namespace Practica02.Datos;

public class ApplicationDbContext : DbContext
{ 
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
         
    }

    public DbSet<UserModel> User { get; set; }
     
    public DbSet<DepartmentModel> Department { get; set; }
    
    
    //otra cosa
    public DbSet<MProduct> Product { get; set; }

    ModelBuilder modelBuilder;

    //Consola de administrador de paquete
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasPostgresExtension("uuid-ossp");

        //relacionar la tabla de Usuarios con la tabla de Departamentos
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasPostgresExtension("uuid-ossp");
        
    }

}