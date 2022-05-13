using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PruebaWCF
{
    [DataContract]
    public class ItemTablaISR
    {
        [DataMember]
        public decimal LimiteInferior { get; set; }
        [DataMember]
        public decimal LimiteSuperior { get; set; }
        [DataMember]
        public decimal CuotaFija { get; set; }
        [DataMember]
        public decimal Excedente { get; set; }
        [DataMember]
        public decimal Subsidio { get; set; }
        [DataMember]
        public decimal Impuesto { get; set; }

        public ItemTablaISR(decimal limInf, decimal limSup, decimal cuotaFija, decimal excedente, decimal subcidio, decimal impuesto)
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