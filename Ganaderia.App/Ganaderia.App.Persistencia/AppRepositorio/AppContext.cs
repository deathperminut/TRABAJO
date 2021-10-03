using Microsoft.EntityFrameworkCore; //Libreria para la base de datos los DbSet
using Ganaderia.App.Dominio;  

namespace Ganaderia.App.Persistencia
{

public class AppContext:DbContext

{

   public DbSet<Persona> Personas { get; set; }
   public DbSet<Ganadero> Ganaderos { get; set; }
   public DbSet<Veterinario> Veterinarios{get;set; }
   public DbSet<HistoriaClinica> HistoriasClinicas{get;set;}
   public DbSet<Vacuna> Vacunas{get;set;}
   public DbSet<Ejemplar> Ejemplares{get;set; }
   public DbSet<Fecha> Fechas{get;set; }
   
   //Conexion 
   // DEBO CREAR UN METODO PRIVADO override para sobreescribir el metodo 
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {

     if ( !optionsBuilder.IsConfigured)
     {
       
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Grupo31");
    
      
     }   

   }


}



}