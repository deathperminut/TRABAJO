

namespace Ganaderia.App.Dominio
{
    public class HistoriaClinica
    {   public int Id { get; set; }
        public float Peso{get;set;} 

        public string InformeVeterinario{get;set;}

        public Fecha Fecha{get;set;}
        
       /* public HistoriaClinica(float peso,string patologias, string informeVeterinario, string consejos,
                                                             int dia,int mes, int año):base(dia,mes,año)
        {
          
          this.Peso=peso;
          this.Patologias=patologias;
          this.InformeVeterinario=informeVeterinario;
          this.Consejos=consejos;


        }*/

    }
}