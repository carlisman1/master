﻿using Microsoft.EntityFrameworkCore;
using MvcWebJobChollometro.Data;
using MvcWebJobChollometro.Models;

namespace MvcWebJobChollometro.Repositories
{
    public class RepositoryChollos
    {
        private ChollometroContext context;

        public RepositoryChollos(ChollometroContext context)
        {
            this.context = context;
        }

        public async Task<List<Chollo>> GetChollosAsync()
        {
            var consulta = from datos in this.context.Chollos
                           orderby datos.Fecha descending
                           select datos;
            return await consulta.ToListAsync();
        }

    }
}
