using System.Collections.Generic;


namespace Ganaderia.App.Dominio
{
    public class Ejemplar
    {
        public int Id { get; set; }
        public string Especie { get; set; }

        public HistoriaClinica HistoriaClinica { get; set; }

        public string Codigo{get;set;}

        public string Genero{get;set;}

        public List<Vacuna> ListaVacunas{get; set; }

        /*public Ejemplar(string especie,HistoriaClinica historiaClinica,
                                                                  List<Vacuna> vacunas)
        {
          
          this.Especie=especie;
          this.HistoriaClinica=historiaClinica;
          this.ListaVacunas=vacunas;

        }*/
       


    }
}