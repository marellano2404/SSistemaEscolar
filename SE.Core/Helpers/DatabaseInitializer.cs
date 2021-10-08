using Microsoft.Extensions.DependencyInjection;
//using SE.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SE.Core.Helpers
{
    /// <summary>
    /// Clase usada para inicializar valores default en la base de datos.
    /// </summary>
    public static class DatabaseInitializer
    {
        /// <summary>
        /// Inicializa los registros default en la base de datos.
        /// </summary>
        /// <param name="serviceProvider">IServiceProvider</param>
        public static void Inicializar(IServiceProvider serviceProvider)
        {
        //    var context = serviceProvider.GetRequiredService<InventarioDbContext>();
        //    context.Database.EnsureCreated();


        //    context.SaveChanges();
        }
    }
}
