using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {
        public Receta()
        {
            RecetaNro = 0;
            Nombre = "";
            TipoReceta = 0;
            Cheff = "";
            Detalle = new List<DetalleReceta>();
        }

        public int RecetaNro { get; set; }
        public string Nombre { get; set; }
        public int TipoReceta { get; set; }
        public string Cheff { get; set; }
        public List<DetalleReceta> Detalle { get; set; }


        public void AgregarDetalle(DetalleReceta detalle)
        {
            Detalle.Add(detalle);
        }
        public void QuitarDetalle(int indice)
        {
            Detalle.RemoveAt(indice);
        }
       
        
    }
}
