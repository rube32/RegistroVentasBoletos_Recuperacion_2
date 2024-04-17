using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVentasBoletos_Recuperacion
{
    class Cliente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool EsPromocionColegios { get; set; }
        public Cliente(string nombre, int edad, bool esPromocionColegios)
        {
            Nombre = nombre;
            Edad = edad;
            EsPromocionColegios = esPromocionColegios;
        }

    }
}
