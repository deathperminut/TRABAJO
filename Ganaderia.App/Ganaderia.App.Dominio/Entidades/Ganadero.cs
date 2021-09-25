using System.Collections.Generic;

namespace Ganaderia.App.Dominio
{
    public class Ganadero:Persona
    {  
       public int Id { get; set; }
       public string Direccion{get;set;}
       public string Ciudad{get;set;} 
       public List<Ejemplar> Ganado{get;set;}
       public Veterinario Veterinario{get;set;}


       /*public Ganadero(string direccion,
                       string ciudad, 
                       List<Ejemplar> ganado,
                       Veterinario veterinario,
                       string nombre,
                       string cedula,
                       string numeroTelefono,
                       string correo,
                       string contra):base(nombre,
                                           cedula,
                                           numeroTelefono,
                                           correo,
                                           contra)
        {
         
         this.Direccion = direccion;
         this.Ciudad = ciudad;
         this.Ganado = ganado;
         this.Veterinario = veterinario;
         que mamera

        }*/
        
    }
}
