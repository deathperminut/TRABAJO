namespace Ganaderia.App.Dominio
{
    public class Vacuna
    {   public int Id { get; set; }
        public string Codigo{get;set;}

        public string Nombre{get;set;}

        public Fecha Fecha{get;set;}
        /*public Vacuna(string Codigo, string Nombre, int dia,int mes, int año):base(dia,mes,año){
            
            
            this.Codigo=Codigo;
            this.Nombre=Nombre;
        
        }*/
    


    }
}