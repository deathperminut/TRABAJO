using Ganaderia.App.Dominio;
using System.Collections.Generic;


namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanadero
    {
         void AddGanadero(Ganadero ganadero);
         Ganadero UpdateGanadero(Ganadero ganadero);
         Ganadero GetGanadero(string Cedula);
         List<Ganadero> GetAllGanaderos();
         void DeleteGanadero(string Cedula);
         void VincularVeterinarioGanadero(Veterinario veterinario, string Cedula);
         void DesvincularVeterinarioGanadero(Veterinario veterinario, string Cedula);



    }
}