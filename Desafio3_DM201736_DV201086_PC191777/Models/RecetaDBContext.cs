using Desafio3_DM201736_DV201086_PC191777.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Desafio3.Models
{
    public class RecetaDBContext : IdentityDbContext<Usuario>      //DbContext
    {
        public RecetaDBContext(DbContextOptions<RecetaDBContext> options)
            : base(options) { }

        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Preparacion> Preparaciones { get; set; }
        public DbSet<Receta> Recetas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeds de Receta
            modelBuilder.Entity<Receta>().HasData(
                new Receta
                {
                    Id = 1,
                    Nombre = "Ensalada César",
                    Descripcion = "Ensalada clásica con pollo, lechuga y aderezo césar.",
                    TiempoPreparacion = 20
                },
                new Receta
                {
                    Id = 2,
                    Nombre = "Pasta Carbonara",
                    Descripcion = "Pasta con salsa de crema, huevo y queso parmesano.",
                    TiempoPreparacion = 30
                },
                new Receta
                {
                    Id = 3,
                    Nombre = "Sopa de Tomate",
                    Descripcion = "Sopa ligera de tomate con albahaca.",
                    TiempoPreparacion = 40
                });

            // Seeds de Ingrediente
            modelBuilder.Entity<Ingrediente>().HasData(
                new Ingrediente
                {
                    Id = 1,
                    Nombre = "Lechuga Romana",
                    Cantidad = 1,
                    Unidad = "Unidad",
                    RecetaId = 1
                },
                new Ingrediente
                {
                    Id = 2,
                    Nombre = "Pollo a la parrilla",
                    Cantidad = 200,
                    Unidad = "Gramos",
                    RecetaId = 1
                },
                new Ingrediente
                {
                    Id = 3,
                    Nombre = "Aderezo césar",
                    Cantidad = 50,
                    Unidad = "Mililitros",
                    RecetaId = 1
                },
                new Ingrediente
                {
                    Id = 4,
                    Nombre = "Pasta espagueti",
                    Cantidad = 250,
                    Unidad = "Gramos",
                    RecetaId = 2
                },
                new Ingrediente
                {
                    Id = 5,
                    Nombre = "Crema de leche",
                    Cantidad = 100,
                    Unidad = "Mililitros",
                    RecetaId = 2
                },
                new Ingrediente
                {
                    Id = 6,
                    Nombre = "Huevo",
                    Cantidad = 1,
                    Unidad = "Unidad",
                    RecetaId = 2
                },
                new Ingrediente
                {
                    Id = 7,
                    Nombre = "Queso Parmesano",
                    Cantidad = 50,
                    Unidad = "Gramos",
                    RecetaId = 2
                },
                new Ingrediente
                {
                    Id = 8,
                    Nombre = "Tomates Frescos",
                    Cantidad = 500,
                    Unidad = "Gramos",
                    RecetaId = 3
                },
                new Ingrediente
                {
                    Id = 9,
                    Nombre = "Albahaca",
                    Cantidad = 5,
                    Unidad = "Hojas",
                    RecetaId = 3
                });

            // Seeds de Preparacion
            modelBuilder.Entity<Preparacion>().HasData(
                new Preparacion
                {
                    Id = 1,
                    Descripcion = "Lavar la lechuga romana y cortarla en trozos",
                    StepOrder = 1,
                    RecetaId = 1
                },
                new Preparacion
                {
                    Id = 2,
                    Descripcion = "Asar el pollo a la parrilla y cortarlo en tiras.",
                    StepOrder = 2,
                    RecetaId = 1
                },
                new Preparacion
                {
                    Id = 3,
                    Descripcion = "Mezclar la lechuga, el pollo y el aderezo césar.",
                    StepOrder = 3,
                    RecetaId = 1
                },
                new Preparacion
                {
                    Id = 4,
                    Descripcion = "Cocinar la pasta en agua hirviendo con sal.",
                    StepOrder = 1,
                    RecetaId = 2
                },
                new Preparacion
                {
                    Id = 5,
                    Descripcion = "Mezclar el huevo, la crema y el queso parmesano.",
                    StepOrder = 2,
                    RecetaId = 2
                },
                new Preparacion
                {
                    Id = 6,
                    Descripcion = "Añadir la mezcla a la pasta caliente.",
                    StepOrder = 3,
                    RecetaId = 2
                },
                new Preparacion
                {
                    Id = 7,
                    Descripcion = "Cortar los tomates y hervirlos hasta que se ablanden.",
                    StepOrder = 1,
                    RecetaId = 3
                },
                new Preparacion
                {
                    Id = 8,
                    Descripcion = "Licuar los tomates y agregar la albahaca.",
                    StepOrder = 2,
                    RecetaId = 3
                },
                new Preparacion
                {
                    Id = 9,
                    Descripcion = "Cocinar por 10 minutos más y servir caliente.",
                    StepOrder = 3,
                    RecetaId = 3
                });
        }
    }
}
