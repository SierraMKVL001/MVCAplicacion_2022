using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PruebaWCF
{
    [DataContract]
    public class AportacionesIMSS
    {
        [DataMember]
        public decimal EnfermedadMaternidad { get; set; }
        [DataMember]
        public decimal InvalidezVida { get; set; }
        [DataMember]
        public decimal Retiro { get; set; }
        [DataMember]
        public decimal Cesantia { get; set; }
        [DataMember]
        public decimal Infonavit { get; set; }

        public AportacionesIMSS(decimal enfMat, decimal invaVida, decimal retiro, decimal cesantia, decimal infonavit)
        {
            EnfermedadMaternidad = enfMat;
            InvalidezVida = invaVida;
            Retiro = retiro;
            Cesantia = cesantia;
            Infonavit = infonavit;
        }
    }
}