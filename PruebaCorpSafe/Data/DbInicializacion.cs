using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCorpSafe.Data
{
    public class DbInicializacion
    {
        public static void Inicializar(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
