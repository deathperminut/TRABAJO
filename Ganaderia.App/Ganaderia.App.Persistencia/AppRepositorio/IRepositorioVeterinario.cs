using Ganaderia.App.Dominio;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
         void AddVeterinario(Veterinario veterinario);
         Veterinario UpdateVeterinario(Veterinario veterinario);
         Veterinario GetVeterinario(string Cedula);
         List<Veterinario> GetAllVeterinarios();
         void DeleteVeterinario(string Cedula);


    }
}