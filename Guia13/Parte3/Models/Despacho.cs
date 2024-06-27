using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte3.Models
{
    public class Despacho
    {
        public int CodigoPostal { get; private set; }
        public double PesoGr { get; private set; }
        public int EmpresaDistribuccion { get; set; }
        public double Pago { get; private set; }
        public bool EsCertificada { get; set; }

        public double CostoBase { get; set; }
        public double IVA { get; set; }
        public double CostoAPagar { get; private set; }

        public Despacho(int codigoPostal, double PesoGr, int EmpresaDistribucion, bool EsCertificada)
        { 
            this.CodigoPostal= codigoPostal;
            this.PesoGr = PesoGr;
            this.EmpresaDistribuccion=EmpresaDistribucion;
            this.EsCertificada = EsCertificada;

            CalcularCosto();
        }

        private void CalcularCosto()
        {
            double Tarifa = 0.5;
            if (EsCertificada)
            {
                Tarifa = 1;
            }
            CostoBase = PesoGr * Tarifa;
            IVA = CostoBase* 21d / 100;
            CostoAPagar = CostoBase + IVA;
        }
    }
}
