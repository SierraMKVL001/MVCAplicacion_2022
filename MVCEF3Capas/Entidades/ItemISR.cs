using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public struct ItemISR 
    {
        public decimal LimiteInferior { get; set; }

        public decimal LimiteSuperior { get; set; }

        public decimal CuotaFija { get; set; }

        public decimal Excedente { get; set; }

        public decimal Subsidio { get; set; }

        public decimal Impuesto { get; set; }

        public ItemISR(decimal limInf, decimal limSup, decimal cuotaFija, decimal excedente, decimal subcidio, decimal impuesto)
        {
            LimiteInferior = limInf;
            LimiteSuperior = limSup;
            CuotaFija = cuotaFija;
            Excedente = excedente;
            Subsidio = subcidio;
            Impuesto = impuesto;
        }
    }

}
