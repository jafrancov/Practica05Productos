using Microsoft.EntityFrameworkCore;
using Practica05Productos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica05Productos.Data
{
    // La carpeta Data se creo para guardar los Context
    // CTRL + . -> para hacer las sugerencias de importacion
    // DbContext perteneces a la libreria Microsoft.EntityFrameworkCore
    // El nombre de sla clase por convencion es recomendable colocar la palabra Context
    public class ProductosDbContext : DbContext
    {
        // short cut "ctor+tab+tab"
        // usamos el constructor de la clase padre
        public ProductosDbContext(DbContextOptions<ProductosDbContext> options): base(options)
        {
        }

        // Esto representa una tabla (DbSet)
        public DbSet<Producto> Productos { get; set; }
    }
}
