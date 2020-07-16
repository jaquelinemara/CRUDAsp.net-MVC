﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreExercicio01Manha.Models
{
    public class OrderContext:DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public OrderContext(DbContextOptions<OrderContext> options):base(options)
        {
        }
    }
}
