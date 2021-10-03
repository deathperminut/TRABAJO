
using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanadero : IRepositorioGanadero
    {
        private readonly AppContext _appContext;//SE CREA UNA VARIABLE QUE SE COMUNIQUE CON LA BASE DE DATOS.

        private Ganadero GanaderoEncontrado=null;
        private Veterinario veterinarionulo=null;

        public RepositorioGanadero(AppContext appContext)
        {
            _appContext = appContext;
        }
        void IRepositorioGanadero.AddGanadero(Ganadero ganadero)
        {
            GanaderoEncontrado=_appContext.Ganaderos.FirstOrDefault(g=> g.Cedula==ganadero.Cedula);
            if(GanaderoEncontrado==null){
            _appContext.Ganaderos.Add(ganadero);
            }
            else{
                return;
            }
            _appContext.SaveChanges();
        }
        Ganadero IRepositorioGanadero.UpdateGanadero(Ganadero ganadero)
        {
           
           GanaderoEncontrado=_appContext.Ganaderos.FirstOrDefault(g=> g.Cedula==ganadero.Cedula);

           if(GanaderoEncontrado!=null)
           {
              GanaderoEncontrado.Nombre=ganadero.Nombre;
              GanaderoEncontrado.NumeroTelefono=ganadero.NumeroTelefono;
              GanaderoEncontrado.Correo=ganadero.Correo;
              GanaderoEncontrado.Contraseña=ganadero.Contraseña;
              GanaderoEncontrado.Direccion=ganadero.Direccion;
             

           }
           _appContext.SaveChanges();
           return GanaderoEncontrado;
        
            

        }
        Ganadero IRepositorioGanadero.GetGanadero(string Cedula)
        {

            GanaderoEncontrado=_appContext.Ganaderos.FirstOrDefault(g=> g.Cedula==Cedula);

            return GanaderoEncontrado;


        }

        List<Ganadero> IRepositorioGanadero.GetAllGanaderos()
        {

            List<Ganadero> lista=_appContext.Ganaderos.ToList();
            return lista;
                

        }
        void IRepositorioGanadero.DeleteGanadero(string Cedula)
        {

            
            GanaderoEncontrado=_appContext.Ganaderos.FirstOrDefault(g=> g.Cedula==Cedula);

            if(GanaderoEncontrado==null)
            {
                 
                 return;


            }
            _appContext.Ganaderos.Remove(GanaderoEncontrado);
            _appContext.SaveChanges();



        }
        void IRepositorioGanadero.VincularVeterinarioGanadero(Veterinario veterinario, string Cedula)
        {

                GanaderoEncontrado=_appContext.Ganaderos.FirstOrDefault(g=> g.Cedula==Cedula);

                if(GanaderoEncontrado.Veterinario.Equals(null))
                {
                    GanaderoEncontrado.Veterinario=veterinario;
                    _appContext.SaveChanges();
                }
                else{
                    return;
                }

        }
        void IRepositorioGanadero.DesvincularVeterinarioGanadero(Veterinario veterinario, string Cedula)
        {

                GanaderoEncontrado=_appContext.Ganaderos.FirstOrDefault(g=> g.Cedula==Cedula);

                if(GanaderoEncontrado.Veterinario.Cedula.Equals(veterinario.Cedula))
                {
                    GanaderoEncontrado.Veterinario=veterinarionulo;
                    _appContext.SaveChanges();
                }
                else
                {
                    return;
                }
                

        }
        
        
    

    } 
}