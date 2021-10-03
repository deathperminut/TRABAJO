using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace Ganaderia.App.Persistencia
{
    public class RepositorioVeterinario: IRepositorioVeterinario
    {

        private readonly AppContext _appContext;//SE CREA UNA VARIABLE QUE SE COMUNIQUE CON LA BASE DE DATOS.

        private Veterinario VeterinarioEncontrado=null;
        
        
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            VeterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(g=> g.Cedula==veterinario.Cedula);
            if(VeterinarioEncontrado==null){
            _appContext.Veterinarios.Add(veterinario);
            }
            else{
                return;
            }
            _appContext.SaveChanges();
        }
        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
           
           VeterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(g=> g.Cedula==veterinario.Cedula);

           if(VeterinarioEncontrado!=null)
           {
              VeterinarioEncontrado.Nombre=veterinario.Nombre;
              VeterinarioEncontrado.NumeroTelefono=veterinario.NumeroTelefono;
              VeterinarioEncontrado.Correo=veterinario.Correo;
              VeterinarioEncontrado.Contraseña=veterinario.Contraseña;
           }
           _appContext.SaveChanges();
           return VeterinarioEncontrado;
        
            

        }
        Veterinario IRepositorioVeterinario.GetVeterinario(string Cedula)
        {

            VeterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(g=> g.Cedula==Cedula);

            return VeterinarioEncontrado;


        }

        List<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {

            List<Veterinario> lista=_appContext.Veterinarios.ToList();
            return lista;
                

        }
        void IRepositorioVeterinario.DeleteVeterinario(string Cedula)
        {

            
            VeterinarioEncontrado=_appContext.Veterinarios.FirstOrDefault(g=> g.Cedula==Cedula);

            if(VeterinarioEncontrado==null)
            {
                 
                 return;


            }
            _appContext.Veterinarios.Remove(VeterinarioEncontrado);
            _appContext.SaveChanges();



        }
        
    }


}