﻿using Microsoft.EntityFrameworkCore;
using MvcCoreEnfermosEF.Models;

namespace MvcCoreEnfermosEF.Data
{
    public class EnfermosContext : DbContext
    {
        public EnfermosContext(DbContextOptions<EnfermosContext> options)
            : base(options) { }

        public DbSet<Enfermo> Enfermos { get; set; }
    }
}
