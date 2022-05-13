using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  struct AportacionesIMSS
    {
        public decimal EnfermedadMaternidad { get; set; }
        public decimal InvalidezVida { get; set; }
        public decimal Retiro { get; set; }
        public decimal Cesantia { get; set; }
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
