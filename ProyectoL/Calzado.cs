using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectoooo
{
    public class Calzado
    {
        private string nombre;
        private string origen;
        private long numeroSerie;
        private int costoUnidad;
        private int unidades;
        private int porcentaje;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Origen { get => origen; set => origen = value; }
        public long NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public int CostoUnidad { get => costoUnidad; set => costoUnidad = value; }
        public int Unidades { get => unidades; set => unidades = value; }
        public int Porcentaje { get => porcentaje; set => porcentaje = value; }
    }
}
