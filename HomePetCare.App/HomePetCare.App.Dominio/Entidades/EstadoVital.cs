using System;

namespace HomePetCare.App.Dominio
{
    
    public class EstadoVital 
    {
        // Identificador único de cada signo vital
        public int Id { get; set; }
        /// Fecha y hora en que se realizó la toma del signo vital 
        public DateTime FechaHora  { get; set; }
         /// Valor numérico del sifno vital  
        public  float Valor{get; set;}
        public TipoVital Signo { get; set; }
    }
}