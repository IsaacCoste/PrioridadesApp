﻿using Microsoft.EntityFrameworkCore;
using PrioridadesApp.Data.Models;

namespace PrioridadesApp.API.DAL;
public class Contexto : DbContext
{
    public DbSet<Prioridades> Prioridades { get; set; }
    public DbSet<Sistemas> Sistemas { get; set; }
    public DbSet<Clientes> Clientes { get; set; }
    public DbSet<Tickets> Tickets { get; set; }
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
}