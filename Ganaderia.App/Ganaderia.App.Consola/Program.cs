using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {    
        private static IRepositorioGanadero _repositorioGanadero= new RepositorioGanadero(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            
        }
    }
}
