using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;
using System.Collections.Generic;

namespace Ganaderia.App.Consola
{
    class Program
    {    
        private static IRepositorioGanadero _repositorioGanadero= new RepositorioGanadero(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repositorioVeterinario= new RepositorioVeterinario(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            
            /*Ganadero ganadero=new Ganadero{
             
                  Cedula="28977266",
                  Nombre="Luisa Fernanda Mendez ",
                  NumeroTelefono="3152381180",
                  Correo="Luisa878@gmail.com",
                  Contraseña="carrito1",
                  Direccion="Cra 5a #48-31",
                  Veterinario=null};
            


            _repositorioGanadero.AddGanadero(ganadero);
            List<Ganadero> lista_ganaderos=_repositorioGanadero.GetAllGanaderos();

            foreach(Ganadero g in lista_ganaderos){

                Console.WriteLine(g.Nombre);
            }*/

            
            Veterinario veterinario=new Veterinario{
             
                  Cedula="14235580",
                  Nombre="Carmen rosa ",
                  NumeroTelefono="3152381180",
                  Correo="carmen878@gmail.com",
                  Contraseña="carrito1",
                  TarjetaProfesional="1005691644"};
            /*
            _repositorioVeterinario.AddVeterinario(veterinario);
            */

            List<Ejemplar> GANADO=new List<Ejemplar>();


            Ejemplar ejemplar_1=new Ejemplar{
                  
                  Especie="Bobino",
                  Codigo="245764",
                  Genero="Macho"

            };
            Ejemplar ejemplar_2=new Ejemplar{
                  
                  Especie="Bobino",
                  Codigo="245721312364",
                  Genero="hembra"

            };
            Ejemplar ejemplar_3=new Ejemplar{
                  
                  Especie="Bobino",
                  Codigo="2435345345764",
                  Genero="Macho"

            };
            GANADO.Add(ejemplar_1);
            GANADO.Add(ejemplar_2);
            GANADO.Add(ejemplar_3);

            

            Ganadero ganadero=new Ganadero{
             
                  Cedula="111111111111",
                  Nombre="Fernando",
                  NumeroTelefono="3152381180",
                  Correo="Fer878@gmail.com",
                  Contraseña="carrito1",
                  Direccion="Cra 5a #48-31",
                  Veterinario=veterinario,
                  Ganado=null};
            
            //_repositorioGanadero.AddGanadero(ganadero);

            //_repositorioGanadero.VincularVeterinarioGanadero(veterinario, "1005691632");
    
            

            



        }
    }
}
