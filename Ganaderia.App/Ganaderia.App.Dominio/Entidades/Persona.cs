namespace Ganaderia.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Cedula {get;set;}
        public string Nombre{get;set;}
        public string NumeroTelefono{get;set;}
        public string Correo {get;set;}
        public string Contraseña{get;set;}

        /*public Persona(string nombre, string cedula, string numeroTelefono, string correo,string contra) 
        {
                this.Cedula = cedula;
                this.Nombre = nombre;
                this.NumeroTelefono = numeroTelefono;
                this.Correo = correo;
                this.Contraseña = contra;
               
        }*/



    }
}