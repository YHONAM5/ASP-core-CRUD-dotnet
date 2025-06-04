COMANDOS PARA CREAR UN PROYECTO DE ESTE ESTICO TODO EL CRUD CON SOLO COMANDOS:
      1) >_ dotnet new webapp -n nombre_proyecto 
      2) >_ cd nombre_proyecto
              // Importamos las librerias para este proyecto
              //Para la coneion con el tipo de base de datos(Sqlite,SqlServer...)
      3) >_ dotnet add package Microsoft.EntityFrameworkCore.Sqlite
              //Para 
      4) >_ dotnet add package Microsoft.EntityFrameworkCore.Design
              //Creamos el Models (entidades)
      5) </>
               // Models/Cliente.cs
                using System.ComponentModel.DataAnnotations;
                namespace demodf.Models
                {
                    public class Cliente
                    {
                        public int Id { get; set; }
                        [Required]
                        public string Nombre { get; set; }
                        [Required]
                        public string Correo { get; set; }
                        public string Telefono { get; set; }
                    }
                }
              //Creacion de DbContext
      6) </> 
              //Data/AppDbContext.cs
              // Data/AppDbContext.cs
              using Microsoft.EntityFrameworkCore;
              using demodf.Models;
              namespace demodf.Data
              {
                  public class AppDbContext : DbContext
                  {
                      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
                      public DbSet<Cliente> Clientes { get; set; }
                  }
              }
                //Modificamos Program.cs
        7) </>
                //Program.cs
                // Agregar DbContext
                builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=localhost;Database=demodfDB;Trusted_Connection=True;TrustServerCertificate=True;"));
                //Instalamos la Herramientas de CodeGenerator
        8) >_ dotnet tool install -g dotnet-aspnet-codegenerator
        9) >_ dotnet add package Microsoft.Visualstudio.Web.CodeGeneration.Design
        10)>_ dotnet add package Microsoft.EntityFrameworkCore.Tools
        //Opcionales para mi
        11)>_ dotnet ef migrations add InitialCreate
        12)>_ dotnet ef database update
        13)>_ dotnet run
//Finalmente el enlase para el acceso
        14)</>
        <li class="nav-item">
            <a class="nav-link text-dark" asp-page="/Clientes/Index">Clientes</a>
        </li>


                
