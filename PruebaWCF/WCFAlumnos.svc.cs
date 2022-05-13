using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Domain.Entidades_Negocio;
using Entidades;

namespace PruebaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IWCFAlumnos
    {
        public AportacionesIMSS CalcularIMSS(int id)
        {
            NIMSS _nImss = new NIMSS();
            NAlumno _nAlumno = new NAlumno();
            Alumno _Alumno = _nAlumno.Consultar(id);
            decimal sldo = _Alumno.SueldoMensual;
            IMSS _Imss = _nImss.Calcular(sldo);
            AportacionesIMSS aportaciones = new AportacionesIMSS(_Imss.EnfyMat, _Imss.InvyVid, _Imss.Retiro, _Imss.Cesantia, _Imss.CreditoInf);
            return aportaciones;
        }

        public ItemTablaISR CalcularISR(int id)
        {
            NItemISR _nItem = new NItemISR();
            NAlumno _nAlumno = new NAlumno();
            NISRResult _nresult = new NISRResult();
            Alumno alumno = _nAlumno.Consultar(id);
            decimal sueldo = alumno.SueldoMensual;
            decimal sldoq = sueldo / 2;
            ItemISR _Item = _nItem.CalcularISR(sueldo);
            ISRResult _ISR = _nresult.Calcular(_Item, sldoq);
            ItemTablaISR itemTablaISR = new ItemTablaISR(_Item.LimInf, _Item.LimSup, _Item.CuotaFija, _Item.PorExced, _Item.Subcidio, _ISR.Impuesto);
            return itemTablaISR;
        }

        
    }
}
