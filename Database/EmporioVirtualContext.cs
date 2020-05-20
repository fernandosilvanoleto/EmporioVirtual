﻿using EmporioVirtual.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Database
{
    public class EmporioVirtualContext : DbContext
    {
        /*
         * EF CORE - ORM
         * SQL ->
         * ORM -> Biblioteca que mapear objetos para banco de dados relacionais
         * 
         */
        public EmporioVirtualContext(DbContextOptions<EmporioVirtualContext> options) : base(options)
        {

        }

        public DbSet<Cliente> clientes { get; set; }

    }
}